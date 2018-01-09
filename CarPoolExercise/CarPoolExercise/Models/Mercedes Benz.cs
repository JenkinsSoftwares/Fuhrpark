using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class MercedesBenz : Funcar
    {
        protected bool Immobilizer;
        public MercedesBenz(Guid NewGUID, string NewManufacturer, bool NewMinibar, bool NewImmobilizer) : base(NewGUID, NewManufacturer, NewMinibar)
        {
            Immobilizer = NewImmobilizer;
        }
    }
}
