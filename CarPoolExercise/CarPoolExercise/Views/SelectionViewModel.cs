using CarpoolExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolExercise.Views
{
    public class SelectionViewModel
    {
        private List<Car> Cars = new List<Car>();

        public SelectionViewModel()
        {
            Firebird Firebird = new Firebird(Guid.NewGuid(), "Firebird", 12.5);
            MajoretteTurbo MajoretteTurbo = new MajoretteTurbo(Guid.NewGuid(), "Majorette", 2);
            FireTurbo Fireturbo = new FireTurbo(Guid.NewGuid(), "Fire_Turbo", true);
            MercedesBenz MercedesBenz = new MercedesBenz(Guid.NewGuid(), "Mercedes", true, true);
            Beachcar Beachcar = new Beachcar(Guid.NewGuid(), "Beachcar", true, true);
            Lowrider Lowrider = new Lowrider(Guid.NewGuid(), "Firebird", 12.5);

            Cars.Add(Firebird);
            Cars.Add(MajoretteTurbo);
            Cars.Add(Fireturbo);
            Cars.Add(MercedesBenz);
            Cars.Add(Beachcar);
            Cars.Add(Lowrider);
        }
           
    }
}
