using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuhrparkverwalter Gustav = new Fuhrparkverwalter();

            Gustav.checkFuhrpark();
        }
    }
}
