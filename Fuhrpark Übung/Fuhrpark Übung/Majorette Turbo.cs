using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Majorette_Turbo : Rennwagen
    {
        protected int Flügel;
        public Majorette_Turbo(Guid NewGUID, string NewHersteller, int NewFlügel) : base(NewGUID, NewHersteller)
        {
            Flügel = NewFlügel;
        }

        public void fahren ()
        {
            Console.WriteLine("Uuhweemmnh");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
