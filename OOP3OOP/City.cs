using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class City : Locality, ILocality
    {
        
        
        public int Population
        {
            get { return population; }
            set {
                if (value >= 12000 && value <= 1000000)
                    population = value; 
                else
                    population = -1;
                }
        }

        public City(string n): base(n)
        {
        }
        public City(string n, int popul):base(n)
        {
            AllPeop += popul;
            Population = popul;
        }
    }
}
