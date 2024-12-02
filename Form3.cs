using Marcihelp.Data;
using Marcihelp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcihelp
{
    public partial class Form3 : Form
    {
        private RendelesDbContext _context;
        public Form3()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            treeView1.Nodes.Clear();

            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;
            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeView1.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };
            node.Tag = kategoria;
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;
            foreach (var gyerekKateoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKateoria, osszeKategoria));
            }
            return node;
        }

        private void atnevezsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.BeginEdit();
            }
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                TermekKategoria atnevezettKategoria = (TermekKategoria)e.Node.Tag;
                atnevezettKategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                var kivalasztotttermekKategoria = (TermekKategoria)e.Node.Tag;
                var termekek = from t in _context.Termek where t.KategoriaId == kivalasztotttermekKategoria.KategoriaId select t;
                dataGridView1.DataSource = termekek.ToList();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
                contextMenuStripKategoria.Show(treeView1, e.Location);
            }
        }

        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria ujtermekKategoria = new TermekKategoria();
            ujtermekKategoria.Nev = "Új főkategória";
            _context.TermekKategoria.Add(ujtermekKategoria);
            _context.SaveChanges();
            TreeNode treeNode = new TreeNode(ujtermekKategoria.Nev);
            treeNode.Tag = ujtermekKategoria;
            treeView1.Nodes.Add(treeNode);
            treeView1.SelectedNode = treeNode;
            treeView1.SelectedNode.BeginEdit();
        }

        private void újAlkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TermekKategoria termekKategoria = new TermekKategoria();
                termekKategoria.Nev = "Új alkategória";
                termekKategoria.SzuloKategoriaId = ((TermekKategoria)treeView1.SelectedNode.Tag).KategoriaId;
                _context.TermekKategoria.Add(termekKategoria);
                _context.SaveChanges();

                TreeNode node = new TreeNode(termekKategoria.Nev);
                node.Tag = termekKategoria;
                treeView1.SelectedNode.Nodes.Add(node);
                treeView1.SelectedNode = node;
                treeView1.SelectedNode.BeginEdit();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba történt az átnevezés során");
            }
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    if (MessageBox.Show("Biztosan törölni akarja?", "Kategóroa törlése", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        try
                        {
                            TermekKategoria termekKategoria = (TermekKategoria)treeView1.SelectedNode.Tag;
                            _context.TermekKategoria.Remove(termekKategoria);
                            _context.SaveChanges();
                            treeView1.SelectedNode.Remove();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hiba történt a törlés során");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Nem törölhető, mert van alkategórája");
                }
            };
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }
    }
}
