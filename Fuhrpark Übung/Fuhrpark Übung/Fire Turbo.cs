using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Fire_Turbo : Rennwagen
    {
        protected bool Turbo;
        public Fire_Turbo(Guid NewGUID, string NewHersteller, bool NewTurbo) : base(NewGUID, NewHersteller)
        {
            Turbo = NewTurbo;
        }

    }
}
