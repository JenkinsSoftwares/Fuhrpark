using CarpoolExercise.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolExercise.Views
{
    public class SelectionViewModel
    {

        private ObservableCollection<Car> _Cars = new ObservableCollection<Car>();

        public ObservableCollection<Car> Carpool
        {
           get { return _Cars; }
           set { _Cars = value; }
        }

        public SelectionViewModel()
        {
            FillCarList();
        }

        public void FillCarList()
        {
            Firebird Firebird = new Firebird(Guid.NewGuid(), "Firebird", 12.5);
            MajoretteTurbo MajoretteTurbo = new MajoretteTurbo(Guid.NewGuid(), "Majorette", 2);
            FireTurbo Fireturbo = new FireTurbo(Guid.NewGuid(), "Fire_Turbo", true);
            MercedesBenz MercedesBenz = new MercedesBenz(Guid.NewGuid(), "Mercedes", true, true);
            Beachcar Beachcar = new Beachcar(Guid.NewGuid(), "Beachcar", true, true);
            Lowrider Lowrider = new Lowrider(Guid.NewGuid(), "Firebird", 12.5);

            _Cars.Add(Firebird);
            _Cars.Add(MajoretteTurbo);
            _Cars.Add(Fireturbo);
            _Cars.Add(MercedesBenz);
            _Cars.Add(Beachcar);
            _Cars.Add(Lowrider);
        }
           
    }
}
