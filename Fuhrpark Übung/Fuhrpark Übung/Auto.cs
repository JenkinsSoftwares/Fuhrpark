using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    abstract class Auto : IFahren
    {
        protected string Hersteller;
        protected Guid GUID;

        public Auto (Guid NewGUID, string NewHersteller)
        {
            GUID = NewGUID;
            Hersteller = NewHersteller;
        }

        public void fahren()
        {
        }
    }
}
