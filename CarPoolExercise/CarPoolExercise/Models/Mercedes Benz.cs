using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class MercedesBenz : Funcar , INotifyPropertyChanged
    {
        protected bool _Immobilizer;
        public MercedesBenz(Guid NewGUID, string NewManufacturer, bool NewMinibar, bool NewImmobilizer) : base(NewGUID, NewManufacturer, NewMinibar)
        {
            _Immobilizer = NewImmobilizer;
        }

        public bool Immobilizer
        {
            get { return _Immobilizer; }
            set
            {
                _Immobilizer = value;
                NotifyPropertyChanged("Immobilizer");
            }
        }
    }
}
