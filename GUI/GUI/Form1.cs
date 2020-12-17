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
        public Form1()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (this.textBox1.Text != "")
            {
                listBox1.Items.Add(this.textBox1.Text);
                this.textBox1.Clear();
                this.textBox1.Focus();

            


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

        
    }
}
