using Marcihelp.Data;
using Marcihelp.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form2 : Form
    {
        public RendelesDbContext _context = new RendelesDbContext();
        BindingList<Ugyfel> ugyfelBindingList = new BindingList<Ugyfel>();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            _context.Ugyfel.Load();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
            LoadUgyfelek();
        }

        private void LoadUgyfelek()
        {
            var k = from x in _context.Ugyfel
                    where x.Nev.Contains(textBox1.Text)
                    orderby x.Nev
                    select x;
            ugyfelBindingSource.DataSource = k.ToList();
            ugyfelBindingSource.ResetCurrentItem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Feltolto();
        }
        private void Feltolto()
        {
            if(ugyfelBindingSource == null) return;
            dataGridView1.DataSource = null;
            var cimek = from x in _context.Cim
                        where x.CimId==((Ugyfel)ugyfelBindingSource.Current).LakcimId
                        select x;
            cimBindingSource.DataSource = cimek.ToList();
            cimBindingSource.ResetCurrentItem();
            dataGridView1.DataSource = cimBindingSource;
        }

    }
}
