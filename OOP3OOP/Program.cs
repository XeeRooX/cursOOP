using System;

namespace OOP3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бюджет
            MoneyFund.Budget = 100000;
            Metropolis Arstocka = new Metropolis("Арстоцка", 5000000);
            Arstocka.PrintInfo();
            Console.WriteLine();


            Simulation.Simulate(Arstocka);
            Console.WriteLine("Бюджет страны: "+ MoneyFund.Budget);
            Arstocka.PrintInfo();
            //Console.WriteLine("Вакцинированных людей: " + Arstocka.GetVaccinatedPeop()); 
        }
    }
}
