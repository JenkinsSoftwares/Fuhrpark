using CarpoolExercise.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolExercise.Models
{
    abstract class Car : IDrive
    {
        protected string Manufacturer;
        protected Guid GUID;

        public Car (Guid NewGUID, string NewManufacturer)
        {
            GUID = NewGUID;
            Manufacturer = NewManufacturer;
        }

        public void Drive()
        {
        }
    }
}
