using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    abstract class Racecar : Car
    {
        public Racecar(Guid NewGUID, string NewManufacturer) : base(NewGUID, NewManufacturer )
        {
        }

        public void Drive()
        {
            Console.WriteLine("Brummbrumm");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
