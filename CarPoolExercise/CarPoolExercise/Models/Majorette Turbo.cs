using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class MajoretteTurbo : Racecar , INotifyPropertyChanged
    {
        protected int _Wings;
        public MajoretteTurbo(Guid NewGUID, string NewManufacturer, int NewWings) : base(NewGUID, NewManufacturer)
        {
            _Wings = NewWings;
        }

        public int Wings
        {
            get { return _Wings; }
            set
            {
                _Wings = value;
                NotifyPropertyChanged("Wings");
            }
        }

        new public void Drive()
        {
            Console.WriteLine("Uuhweemmnh");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
