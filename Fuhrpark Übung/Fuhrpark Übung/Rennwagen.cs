using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    abstract class Rennwagen : Auto
    {
        public Rennwagen(Guid NewGUID, string NewHersteller) : base(NewGUID, NewHersteller)
        {
        }

        public void fahren()
        {
            Console.WriteLine("Brummbrumm");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
