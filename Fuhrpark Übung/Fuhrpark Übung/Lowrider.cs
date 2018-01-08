using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Lowrider : Firebird, ISpringen
    {
        public Lowrider(Guid NewGUID, string NewHersteller, double NewWatt) : base(NewGUID, NewHersteller, NewWatt)
        {
        }

        public void Springen()
        {
            Console.WriteLine("I am a Lowrider");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
