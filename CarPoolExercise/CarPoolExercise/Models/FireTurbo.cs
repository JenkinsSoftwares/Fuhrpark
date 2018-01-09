using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class FireTurbo : Racecar , INotifyPropertyChanged
    {
        protected bool _Turbo;
        public FireTurbo(Guid NewGUID, string NewManufacturer, bool NewTurbo) : base(NewGUID, NewManufacturer)
        {
            _Turbo = NewTurbo;
        }

        public bool Turbo
        {
            get { return _Turbo; }
            set
            {
                _Turbo = value;
                NotifyPropertyChanged("Turbo");
            }
        }

    }
}
