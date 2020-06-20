using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class FrmRegistracija : Form
    {
        RepozitorijKorisnika korisnici = new RepozitorijKorisnika();
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegisracija_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Ime = txtIme.Text;
            korisnik.Prezime = txtPrezime.Text;
            korisnik.Email = txtEmail.Text;
            korisnik.Lozinka = txtLozinka.Text;
            korisnik.DatumRodjenja = new DateTime(2000,5,7);
            korisnik.BrojKartice = txtKartica.Text;
            korisnik.BrojMobitela = txtMobitel.Text;
            korisnik.Uloga = "1";
            korisnici.DodajKorisnika(korisnik);
            Close();
        }

        private void txtPotvrdaLozinke_Leave(object sender, EventArgs e)
        {
            if (txtLozinka.Text != txtPotvrdaLozinke.Text)
                MessageBox.Show("Lozinke se ne podudaraju!");
        }
    }
}
