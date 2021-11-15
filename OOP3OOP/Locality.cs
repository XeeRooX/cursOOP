using System;
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
        public Locality()
        {

        }
        public int GetPopulation() 
        {
            return population;
        }
        public int GetVaccinatedPeop() 
        {          
            return (int) (ProcOfVac / 100 * population);
        }

        public int GetAllPeople() {
            return AllPeop;
        }
        public override void PrintInfo() {
            base.PrintInfo();
            Console.WriteLine("Название: "+ Name);
            Console.WriteLine("Популяция: " + population);
            Console.WriteLine("Заболевших: "+ (int)(ProcOfCases/100*population));
            Console.WriteLine("Вакцинированных: " + (int)(ProcOfVac / 100 * population));
        }
    }
}
