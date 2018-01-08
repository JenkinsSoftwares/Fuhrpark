using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Firebird : Rennwagen
    {
        protected double Watt;
        public Firebird(Guid NewGUID, string NewHersteller, double NewWatt) : base(NewGUID, NewHersteller)
        {
            Watt = NewWatt;
        }


    }
}
