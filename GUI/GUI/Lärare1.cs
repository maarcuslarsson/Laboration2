using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Lärare1: Användare, ILärare   
    {
        //public List<Kurs> lärareKurs = new List<Kurs>();
        public List<Labb> lärareLabb = new List<Labb>();

        private string namn;
        private string pernr;

        // get & set för att komma åt de privata variablerna
        // samt att ge dem värden
        public string PerNr
        {
            get { return pernr; }
            set { pernr = value; }
        }


        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        public Lärare1()
        {

        }

        // konstruktor 
        // detta är det första som körs när en ny lärare skapas
        public Lärare1(string n, string p)
        {
            Namn = n;
            PerNr = p;
        }

        public void LäggTillLärare()
        {
            

        }
    }
}





