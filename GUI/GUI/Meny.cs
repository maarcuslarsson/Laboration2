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
    public partial class Meny : Form
    
    {
        public Datastore datastore { get; set; }


        public Meny(Datastore Data)
        {

            InitializeComponent();

            datastore = Data;
        }

        private void btnlärare_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(datastore);

            f.Show();
            this.Hide();

        }
    }
}
