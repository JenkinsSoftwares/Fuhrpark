using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Mercedes_Benz : Funcar
    {
        protected bool Immobilizer;
        public Mercedes_Benz(Guid NewGUID, string NewManufacturer, bool NewMinibar, bool NewImmobilizer) : base(NewGUID, NewManufacturer, NewMinibar)
        {
            Immobilizer = NewImmobilizer;
        }
    }
}
