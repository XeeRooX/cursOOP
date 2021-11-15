using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class MoneyFund
    {

        static public int PriceVac { get; } = 10;
        public int Tax { get; } = 30;
        public int Benefits { get; } = 100;
        static private int budget;
        static public int Budget
        {
            get { return budget; }
            set 
            { if (value > 0)
                {
                    budget = value;
                }
                else
                    budget = -1;
            }
        }
        public static void Vaccinade(int countP)
        {           
            Budget -= countP * PriceVac;
        }
        public int ProcWorkers { get; } = 65;
    }
}
