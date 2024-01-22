using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_AS
{
    public partial class Knjige : Form
    {
        public Knjige()
        {
            List<KnjigaClass> knjigaList = new List<KnjigaClass>();
            InitializeComponent();
            this.knjigaList.Items.AddRange(items);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void osvjezibtn_Click(object sender, EventArgs e)
        {
            ispisKnjigetxt.Clear();

            ispisKnjigetxt.Text = "Referenca: " + "\n" + "Naziv" + "\n" + "Autor" + "\n" + "Izdavac" + "\n" + "Godina izdanja" + "\n" + "ISBN"+ "\n\n";
            foreach (KnjigaClass upisknjige in knjigaList)
            {
                ispisKnjigetxt.AppendText("\n" + upisknjige.ToString());
            }
        }
        private void ispisKnjigetxt_TextChanged(object sender, EventArgs e) {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
        }

        private RichTextBox displayMembers(List<KnjigaClass> knjigaList)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
 }
    

