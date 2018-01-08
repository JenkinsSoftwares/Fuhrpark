﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrpark_Übung
{
    class Fuhrparkverwalter
    {
        private List<Auto> Wagen = new List<Auto>();
        
        public Fuhrparkverwalter()
        {
            Firebird Firebird = new Firebird(Guid.NewGuid(), "Firebird", 12.5);
            Majorette_Turbo Majorette_Turbo = new Majorette_Turbo(Guid.NewGuid(), "Majorette", 2);
            Fire_Turbo Fire_Turbo = new Fire_Turbo(Guid.NewGuid(), "Fire_Turbo", true);
            Mercedes_Benz Mercedes_Benz = new Mercedes_Benz(Guid.NewGuid(), "Mercedes", true, true);
            Beachcar Beachcar = new Beachcar(Guid.NewGuid(), "Beachcar", true, true);
            Lowrider Lowrider = new Lowrider(Guid.NewGuid(), "Firebird", 12.5);

            Wagen.Add(Firebird);
            Wagen.Add(Majorette_Turbo);
            Wagen.Add(Fire_Turbo);
            Wagen.Add(Mercedes_Benz);
            Wagen.Add(Beachcar);
            Wagen.Add(Lowrider);
        }

        public void checkFuhrpark()
        {
            Wagen.ForEach(Probefahrt);
        }

        public void Probefahrt(Auto Auto)
        {
            Auto.fahren();
        }

    }
}
