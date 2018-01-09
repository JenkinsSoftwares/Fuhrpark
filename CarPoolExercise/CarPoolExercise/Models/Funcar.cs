using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    abstract class Funcar : Car
    {
        protected bool Minibar;
        public Funcar(Guid NewGUID, string NewManufacturer, bool NewMinibar) : base(NewGUID, NewManufacturer)
        {
            Minibar = NewMinibar;
        }

        new public void Drive()
        {
            Console.WriteLine("scheeechuiehh");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
