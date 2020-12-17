using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
  

    class Lärare1
        
    {
        public class Lärare: Användare

        {
           public void LäggTillLärare()

            {
                String [] LärarNamn = new string [10];

                for (int i = 0; i < LärarNamn.Length; i++)
                {
                    LärarNamn[i] = Console.ReadLine();
                }
            }
        }
    }


}


