using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        // variabler (liten bokstav)
        private string pernr;
        private string namn;

        // Properties (börjar med stor bokstav)
        public Datastore Datastore { get; set; }
        public Form1(Datastore datastore)
        {
            InitializeComponent();

            Datastore = datastore;
            listaupdatera();
        }

        // uppdatera listbox lärare
        private void listaupdatera()
        {
            // tömmer listbox
            listBox1.Items.Clear();

            // går igenom listan och skriver ut alla lärarnamn
            for (int i = 0; i < Datastore.LärareDB.Count; i++)
            {
                listBox1.Items.Add(Datastore.LärareDB[i].Namn);
            }
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (this.textBox1.Text != "" && textBox2.Text != "")
            {
                //listBox1.Items.Add(this.textBox1.Text);
                //this.textBox1.Clear();
                //this.textBox1.Focus();

                // Om textbox med namn inte är tom "" så flyttas det över till variablen 'namn'
                namn = textBox1.Text;

                // Om textbox med personnummer inte är tom "" så flyttas det över till variablen 'pernr'
                pernr = textBox2.Text;


                // skapar en ny lärare
                Datastore.LärareDB.Add(new Lärare1(namn, pernr));

                // tömmer textbox'ar efter lärare lagts till
                textBox1.Clear();
                textBox2.Clear();
                listaupdatera();
            }
            else
            {
                MessageBox.Show("skriv in ett namn.");

            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex>=0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                    
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntillbaka_Click(object sender, EventArgs e)
        {
            Meny meny = new Meny( Datastore );
            this.Hide();
            meny.Show();
        }
    }
}
