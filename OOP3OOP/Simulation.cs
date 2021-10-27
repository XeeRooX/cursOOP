using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class Simulation
    {
        public int MyProperty { get; set; }
        static public void Simulate(Locality l) 
        {
            St1_Vaccinade(l);
        }
        private static void St1_Vaccinade(Locality l)
        {
            int noney = MoneyFund.Budget;
            float procCases = l.ProcOfCases;
            float population = l.GetPopulation();
            int countVaccin = l.GetVaccinatedPeop();



        }
    }
}
