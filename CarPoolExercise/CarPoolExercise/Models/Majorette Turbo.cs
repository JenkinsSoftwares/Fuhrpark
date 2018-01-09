using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class MajoretteTurbo : Racecar
    {
        protected int Wings;
        public MajoretteTurbo(Guid NewGUID, string NewManufacturer, int NewWings) : base(NewGUID, NewManufacturer)
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
