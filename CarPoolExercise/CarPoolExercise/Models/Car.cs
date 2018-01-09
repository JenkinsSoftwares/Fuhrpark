using CarpoolExercise.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    // test
    abstract public class Car : IDrive , INotifyPropertyChanged
    {
        protected string _Manufacturer;
        protected Guid _GUID;

        public event PropertyChangedEventHandler PropertyChanged;

        public Car (Guid NewGUID, string NewManufacturer)
        {
            _GUID = NewGUID;
            _Manufacturer = NewManufacturer;
        }

        public string Manufacturer
        {
            get { return _Manufacturer; }
            set
            {
                _Manufacturer = value;
                NotifyPropertyChanged("Manufacturer");
            }
        }

        public Guid Guid
        {
            get { return _GUID; }
            set
            {
                _GUID = value;
                INotifyPropertyChanged("Guid");
            }
        }

        public void Drive()
        {
        }
    }
}
