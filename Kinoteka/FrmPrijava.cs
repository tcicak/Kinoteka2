using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess;

namespace Kinoteka
{
    public partial class FrmPrijava : Form
    {
        RepozitorijKorisnika korisnici = new RepozitorijKorisnika();
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            int greska = 0;
            string email = ProvjeraEmail(txtEmail.Text);
            if (email  != txtEmail.Text) { 
                MessageBox.Show("Korisnik ne postoji");
                greska = 1;
            }
            if (txtLozinka.Text != "")
            { 
                string mail = ProvjeraLozinka(txtEmail.Text, txtLozinka.Text);
                if (mail != txtEmail.Text) { 
                 MessageBox.Show("Lozinka nije ispravna");
                    greska = 1;
                }
            }
            if(greska == 0)
            {
                FrmPocetna forma = new FrmPocetna();
                Close();
                forma.ShowDialog(); 
            }
        }

        private string ProvjeraEmail(string email)
        {
            string emaila = "";
            string sql = $"SELECT Email FROM Korisnik WHERE Email='{email}'";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                emaila = dataReader["Email"].ToString();
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return emaila;
        }

        private string ProvjeraLozinka(string email, string lozinka)
        {
            string emaila = "";
            
            string sql = $"SELECT Email FROM Korisnik WHERE Email='{email}' AND Lozinka='{lozinka}'";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                emaila = dataReader["Email"].ToString();
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return emaila;
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
        }
    }
}
