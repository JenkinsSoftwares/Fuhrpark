using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
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
