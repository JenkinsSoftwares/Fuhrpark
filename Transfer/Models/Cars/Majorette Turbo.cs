using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Majorette_Turbo : Racecar
    {
        protected int Wings;
        public Majorette_Turbo(Guid NewGUID, string NewManufacturer, int NewWings) : base(NewGUID, NewManufacturer)
        {
            Wings = NewWings;
        }

        new public void Drive()
        {
            Console.WriteLine("Uuhweemmnh");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
