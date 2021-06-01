using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Practice properties concept in which we pass parameters using getter and setter accessors while keeping interest rate property to private setter.
    /// </summary>
    public class ProgramForAccounts
    {
        static void Main(string[] args)
        {
            //Accounts ac1 = new Accounts();
            //ac1.InitialAmount = 500;
            Accounts ac2 = new Accounts(5000);
            //Accounts.InterestRate = 10;
            Console.WriteLine(ac2.InitialAmount);
            Console.WriteLine(Accounts.InterestRate);
        }

    }
    class Accounts
    {
        private float init_amount;
        private static float interest;

        public float InitialAmount 
        {
            set
            {
                if(value < 1000)
                {
                    Console.WriteLine("Initial amount cannot be less than thousand");
                    return;
                }
                init_amount = value;
            }
            get
            {
                return init_amount;
            }
        }
        public static float InterestRate
        {
            private set
            {
                interest = value;
            }
            get
            {
                return interest;
            }
        }

        public Accounts()
        {
            this.InitialAmount = 10000;
        }

        public Accounts(float amt)
        {
            this.InitialAmount = amt;
        }

        static Accounts()
        {
            Accounts.InterestRate = 9.5f;
        }

    }
}
