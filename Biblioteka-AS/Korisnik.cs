using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Biblioteka_AS
{
    public partial class Korisnik : Form
    {
        List <KorisnikClass> korisnikList = new List<KorisnikClass>();
        public Korisnik()
        {
            InitializeComponent();
        }

        private void imekorisniktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string message =imekorisniktxt.Text + prezimekorisniktxt.Text + Convert.ToString(dobkorisniktxt.Text) + brojteltxt.Text + emailtxt.Text + oibkorisniktxt.Text + adresakorisniktxt.Text;
            string title = "Želite li ovo spremiti?";
            MessageBox.Show(message, title);
            
        }

        public static List<KorisnikClass> CreateUserList()
            {
                List<KorisnikClass> korisnikLista = new List<KorisnikClass> { };
                return korisnikLista;
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*DialogResult result = MessageBox.Show("Jeste li sigurni da ovo želite spremiti?", "Upozorenje", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Yes)
            {
                KorisnikClass upiskorisnik = new KorisnikClass(imekorisniktxt.Text, prezimekorisniktxt.Text, Convert.ToString(dobkorisniktxt.Text), brojteltxt.Text, emailtxt.Text, oibkorisniktxt.Text, adresakorisniktxt.Text);
                korisnikList.Add(upiskorisnik);
            }*/
    }
}
