using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class Metropolis : City, ILocality
    {
        public int Population
        {
            get { return population; }
            set
            {
                if (value > 1000000)
                    population = value;
                else
                    population = -1;
            }
        }

        public Metropolis(string n, int popul) : base(n)
        {
            AllPeop += popul;
            Population = popul;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Тип населенного пункта: Мегаполис");
            base.PrintInfo();                
        }
    }
}
