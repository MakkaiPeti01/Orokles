using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember jozsef = new Ember("Józsi", 37);
            Tanulo Blazin = new Tanulo("Blazin",16,"10A");
            Tanarok olga = new Tanarok("Olga",25,"Testnevelés",false);
            Tanarok stark = new Tanarok("Stark",40,"Biofizika",true);
            jozsef.Koszon();
            Blazin.Koszon();
            olga.Koszon();
            stark.Koszon();
            Console.ReadKey();
        }
    }
}
