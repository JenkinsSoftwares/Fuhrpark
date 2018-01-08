using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Mercedes_Benz : Freizeitwagen
    {
        protected bool Wegfahrsperre;
        public Mercedes_Benz(Guid NewGUID, string NewHersteller, bool NewMinibar, bool NewWegfahrsperre) : base(NewGUID, NewHersteller, NewMinibar)
        {
            Wegfahrsperre = NewWegfahrsperre;
        }
    }
}
