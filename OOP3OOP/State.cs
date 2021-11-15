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

<<<<<<< HEAD
=======
        public virtual int GetMoney() 
        {
            return MoneyFund.Budget;
        }

        public void Meth() 
        {
            Console.WriteLine("Вызов метода Meth() в классе State");
        }
>>>>>>> d9d41f1c9b98110f0cfe628b271cb786d0be72eb
    }
}
