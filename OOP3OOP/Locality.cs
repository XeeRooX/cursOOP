﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
     class Locality : State
    {
        public string Name { get; set; }
        protected  int population;
        protected string name;
        
        public Locality(string n):base()
        {
            Name = n;
        }
        public int GetPopulation() 
        {
            return population;
        }
        public int GetVaccinatedPeop() 
        {
            return (int) ProcOfVac / 100 * population;
        }
    }
}
