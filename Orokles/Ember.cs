using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Ember
    {
        protected string nev;
        protected int eletkor;
        public Ember(string nev, int eletkor)
        {
            this.nev = nev;
            this.eletkor = eletkor;
        }
        public void Koszon()
        {
            Console.WriteLine($"{nev} vagyok {eletkor} éves.");
        }
    }
}
