using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class Firebird : Racecar , INotifyPropertyChanged
    {
        protected double _Watt;
        public Firebird(Guid NewGUID, string NewManufacturer, double NewWatt) : base(NewGUID, NewManufacturer)
        {
            _Watt = NewWatt;
        }

        public double Watt
        {
            get { return _Watt; }
            set
            {
                _Watt = value;
                NotifyPropertyChanged("Watt");
            }
        }
    }
}
