using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Beachcar : Freizeitwagen, ISpringen
    {
        protected bool Sonnenschutz;
        public Beachcar(Guid NewGUID, string NewHersteller, bool NewMinibar, bool NewSonnenschutz) : base(NewGUID, NewHersteller, NewMinibar)
        {
            Sonnenschutz = NewSonnenschutz;
        }

        public void Springen()
        {
            Console.WriteLine("JumpJump");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
