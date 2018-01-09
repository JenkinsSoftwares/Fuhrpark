using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    abstract class Racecar : Car
    {
        public Racecar(Guid NewGUID, string NewManufacturer) : base(NewGUID, NewManufacturer )
        {
        }

        new public void Drive()
        {
            Console.WriteLine("Brummbrumm");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
