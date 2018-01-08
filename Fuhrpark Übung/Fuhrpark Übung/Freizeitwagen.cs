using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    abstract class Freizeitwagen : Auto
    {
        protected bool Minibar;
        public Freizeitwagen(Guid NewGUID, string NewHersteller, bool NewMinibar) : base(NewGUID, NewHersteller)
        {
            Minibar = NewMinibar;
        }

        public void fahren()
        {
            Console.WriteLine("scheeechuiehh");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
