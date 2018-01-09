using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class Firebird : Racecar
    {
        protected double Watt;
        public Firebird(Guid NewGUID, string NewManufacturer, double NewWatt) : base(NewGUID, NewManufacturer)
        {
            Watt = NewWatt;
        }


    }
}
