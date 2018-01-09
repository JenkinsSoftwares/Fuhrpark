using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class FireTurbo : Racecar
    {
        protected bool Turbo;
        public FireTurbo(Guid NewGUID, string NewManufacturer, bool NewTurbo) : base(NewGUID, NewManufacturer)
        {
            Turbo = NewTurbo;
        }

    }
}
