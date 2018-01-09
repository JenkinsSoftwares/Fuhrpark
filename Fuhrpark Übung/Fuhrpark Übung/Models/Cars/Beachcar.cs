using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Beachcar : Funcar, IJump
    {
        protected bool Sunscreen;
        public Beachcar(Guid NewGUID, string NewManufacturer, bool NewMinibar, bool NewSunscreen) : base(NewGUID, NewManufacturer, NewMinibar)
        {
            Sunscreen = NewSunscreen;
        }

        public void Jump()
        {
            Console.WriteLine("JumpJump");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
