using CarpoolExercise.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class Lowrider : Firebird, IJump
    {
        public Lowrider(Guid NewGUID, string NewManufacturer, double NewWatt) : base(NewGUID, NewManufacturer, NewWatt)
        {
        }

        public void Jump()
        {
            Console.WriteLine("I am a Lowrider");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
