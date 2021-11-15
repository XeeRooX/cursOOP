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
            float procBudgNaVaccin = 0.30f;
            int money = MoneyFund.Budget;
            // процент заболевших
            float procCases = l.ProcOfCases;
            // Популяция
            float population = l.GetPopulation();
            // Колличесво вакцинированных
            int countVaccin = l.GetVaccinatedPeop();   

            // Сколько город может себе позволить потратить на прививки
            int locVaccBudget = (int)((population/l.GetAllPeople())*procBudgNaVaccin*money);
            // Люди которые подходят для вакцинации в городе
            int ludiNaVacc =(int)(population - countVaccin - (population * procCases/100));
         
            // Удаление из бюджета средств, затраченных на вакцинацию и увелечение процента вакцинированных
            if (MoneyFund.PriceVac * ludiNaVacc > locVaccBudget)
            {      
                l.ProcOfVac = (countVaccin + (locVaccBudget / MoneyFund.PriceVac)) / population * 100;
                MoneyFund.Vaccinade(locVaccBudget / MoneyFund.PriceVac);
            }
            else 
            {
                l.ProcOfVac = (countVaccin+ ludiNaVacc) / population * 100;
                MoneyFund.Vaccinade(ludiNaVacc);
            }
        }
    }
}
