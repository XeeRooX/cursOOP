using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class Settlement : Locality, ILocality
    {
        public int Population
        {
            get { return population; }
            set
            {
                if (value > 0 && value < 12000)
                    population = value;
                else
                    population = -1;
            }
        }

        public Settlement(string n, int popul) : base(n)
        {
            AllPeop += popul;
            Population = popul;
        }
    }
}
