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

    public partial class Form4 : Form
    {
        private readonly RendelesDbContext _context;
        BindingList<Termek> termekBindingList = new BindingList<Termek>();

        public Form4()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            termekBindingList = _context.Termek.Local.ToBindingList();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadTermekek();
            _context.Termek.Load();
            termekBindingSource.DataSource = termekBindingList;
            LoadCimek();
        }

        private void szuroTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(szuroTextBox.Text) || x.Email.Contains(szuroTextBox.Text)
                    orderby x.Nev
                    select x;
            ugyfelBindingSource.DataSource = q.ToList();
            ugyfelBindingSource.ResetCurrentItem();
        }
        private void LoadTermekek()
        {

        }
        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO1
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };
            cimEgybenDTO1BindingSource.DataSource = q.ToList();
            cimEgybenDTO1BindingSource.ResetCurrentItem();

        }
        private void ugyfelekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource == null) return;
            dataGridView1.DataSource = null;
            var rendeles = from x in _context.Rendeles
                           where x.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select x;
            rendelesBindingSource.DataSource = rendeles.ToList();
            rendelesekLsitBox.DataSource = rendelesBindingSource;

            if (rendelesekLsitBox.Items.Count > 0)
            {
                rendelesekLsitBox.SelectedIndex = 0;
            }
            rendelesBindingSource.ResetCurrentItem();
        }
        private void LoadRendelesTetel()
        {
            if (rendelesBindingSource.Current == null) return;

            var q = from rt in _context.RendelesTetel
                    where rt.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                    select new RendelesTetelDTO
                    {
                        TetelId = rt.TetelId,
                        TermekNev = rt.Termek.Nev,
                        Mennyiseg = rt.Mennyiseg,
                        EgysegAr = rt.EgysegAr,
                        Afa = rt.Afa,
                        NettoAr = rt.NettoAr,
                        BruttoAr = rt.BruttoAr
                    };

            dataGridView1.DataSource = q.ToList();
            UpdateVegosszeg();
        }

        private void rendelesekLsitBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
        }

        private void ujrendelesButton_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();

            if (cim == null)
            {
                MessageBox.Show("Nincs cím megadva.");
                return;
            }

            var ujRendeles = new Rendeles()
            {
                UgyfelId = ((Ugyfel)ugyfelBindingSource.Current).UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };

            _context.Rendeles.Add(ujRendeles);
            Mentés();

            label9.Text = $"A rendelés teljes értéke: {ujRendeles.Vegosszeg} Ft";

            LoadRendelesek();

            rendelesekLsitBox.SelectedItem = ujRendeles;
        }
        private void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private const decimal AFA = .27m;
        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mennyisegTextBox.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiség!");
                return;
            }

            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy termék!");
                return;
            }

            var kivalasztottTermek = (Termek)termekBindingSource.Current;

            decimal bruttoAr = kivalasztottTermek.AktualisAr * (1 + AFA);

            var ujTetel = new RendelesTetel
            {
                RendelesId = ((Rendeles)rendelesBindingSource.Current).RendelesId,
                TermekId = kivalasztottTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = kivalasztottTermek.AktualisAr,
                Afa = AFA,
                NettoAr = kivalasztottTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };

            _context.RendelesTetel.Add(ujTetel);
            Mentés();

            LoadRendelesTetel();
        }

        private void torolButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva tétel!");
                return;
            }

            var selectedTetel = dataGridView1.SelectedRows[0].DataBoundItem as RendelesTetelDTO;

            var tetel = (from rt in _context.RendelesTetel
                         where rt.TetelId == selectedTetel!.TetelId
                         select rt).FirstOrDefault();

            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                Mentés();

                LoadRendelesTetel();
            }
        }
        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null) return;

            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;

            var vegosszeg = _context.RendelesTetel
                .Where(rt => rt.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(rt => rt.Mennyiseg * rt.BruttoAr);

            kivalasztottRendeles.Vegosszeg = vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny);

            Mentés();

            rendelesBindingSource.ResetBindings(false);
        }
    }

    public class RendelesTetelDTO
    {
        public int TetelId { get; set; }
        public string? TermekNev { get; set; }
        public int Mennyiseg { get; set; }
        public decimal EgysegAr { get; set; }
        public decimal Afa { get; set; }
        public decimal NettoAr { get; set; }
        public decimal BruttoAr { get; set; }
    }

}
