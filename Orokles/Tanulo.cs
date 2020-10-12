using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanulo : Ember
    {
        private string osztaly;
        public Tanulo(string nev, int eletkor, string osztaly) : base(nev, eletkor)
        {
            this.osztaly = osztaly;      
        }
        public new void Koszon()
        {
            Console.WriteLine("{0} vagyok {1} éves {2} osztályos",nev,eletkor,osztaly);
        }
    }
}
