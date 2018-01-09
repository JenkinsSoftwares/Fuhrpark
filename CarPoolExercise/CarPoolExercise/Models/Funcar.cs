using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    abstract class Funcar : Car , INotifyPropertyChanged
    {
        protected bool _Minibar;
        public Funcar(Guid NewGUID, string NewManufacturer, bool NewMinibar) : base(NewGUID, NewManufacturer)
        {
            _Minibar = NewMinibar;
        }

        public bool Minibar
        {
            get { return _Minibar; }
            set
            {
                _Minibar = value;
                NotifyPropertyChanged("Minibar");
            }

        new public void Drive()
        {
            Console.WriteLine("scheeechuiehh");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
