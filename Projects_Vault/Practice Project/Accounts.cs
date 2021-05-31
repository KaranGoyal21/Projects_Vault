using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    class Accounts
    {
        float init_amount;
        static float interest;

        public float InitialAmount 
        {
            set
            {
                if(value < 1000)
                {
                    Console.WriteLine("Initial amount cannot be less than zero");
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

        static void Main(string[] args)
        {
            //Accounts ac1 = new Accounts();
            //ac1.InitialAmount = 500;
            Accounts ac2 = new Accounts(5000);
            Accounts.InterestRate = 10;
            Console.WriteLine(ac2.InitialAmount);
            Console.WriteLine(Accounts.InterestRate);
        }
    }
}
