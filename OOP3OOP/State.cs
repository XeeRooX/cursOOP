using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3OOP
{
    class State : Factors
    {
        protected static int AllPeop { get; set; }
        protected static int AllCases { get; set; }
        protected static int AllVaccinated { get; set; }
        protected static string NameState { get; set; }

        public State():base()
        {
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Название страны: {NameState}");
        }


        public virtual int GetMoney() 
        {
            return MoneyFund.Budget;
        }

        public void Meth() 
        {
            Console.WriteLine("Вызов метода Meth() в классе State");
        }

    }
}
