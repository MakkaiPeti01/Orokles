using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanarok : Ember
    {
        public string szak;
        private bool osztalyfonok;

        public Tanarok(string nev, int eletkor, string szak, bool osztalyfonok):base(nev,eletkor)
        {
            this.szak = szak;
            this.osztalyfonok = osztalyfonok;
        }
        public new void Koszon()
        {
            if (osztalyfonok)
            {
                Console.WriteLine($"{nev} vagyok, {szak} tanar. Osztályfőnök");
            }
            else
            {
                Console.WriteLine($"{nev} vagyok, {szak} tanar.");
            }
        }
    }
}
