using CarpoolExercise.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    class Beachcar : Funcar, IJump , INotifyPropertyChanged
    {
        protected bool _Sunscreen;
        public Beachcar(Guid NewGUID, string NewManufacturer, bool NewMinibar, bool NewSunscreen) : base(NewGUID, NewManufacturer, NewMinibar)
        {
            _Sunscreen = NewSunscreen;
        }

        public bool Sunscreen
        {
            get { return _Sunscreen; }
            set
            {
                _Sunscreen = value;
                NotifyPropertyChanged("Sunscreen");
            }
        }

        public void Jump()
        {
            Console.WriteLine("JumpJump");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
