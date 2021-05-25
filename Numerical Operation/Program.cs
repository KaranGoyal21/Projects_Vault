﻿using System;

namespace Numerical_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             GetEvenOdd();

             AccountLogin();

             GetGrade();

             CheckVowel();

             GetLoopEvenOddValues();

             CheckprimeValueType1();

             CheckprimeValueType2();

             CheckprimeValueType3();

             First100PrimeNumbers();

             DisplayTable();

             DisplayTableTillGivenValue();

             CalculateDigits();

             LimitPinAttempts();

             RetryPinAttempts();
             */
        }

        static void GetEvenOdd()
        {
            // to check if the user given input integer value is Even or Odd in nature. 

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }

        static void AccountLogin()
        {
            // to login the user with specific username & password only, any wrong value should be displayed with invalid inputs.

            string username = Console.ReadLine();
            var password = Console.ReadLine();

            if (username == "karan" && password == "xyz1234")
            {
                Console.WriteLine("Welcome Karan");
            }
            else
            {
                Console.WriteLine("Invalid Inputs");
            }
        }

        static void GetGrade()
        {
            // to get inputs from user and convert it into GRADE A,B,C,D format with percentage range of 100-80,80-60,60-40,40-0 respectively.

            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 100)
            {
                if (num >= 80)
                {
                    Console.WriteLine(num + " is a Grade A");
                }
                else if (num >= 60)
                {
                    Console.WriteLine(num + " is a Grade B");
                }
                else if (num >= 40)
                {
                    Console.WriteLine(num + " is a Grade C");
                }
                else
                {
                    Console.WriteLine(num + " is a Grade D");
                }
            }
            else
            {
                Console.WriteLine(num + " is an Invalid Input \nEnter Percentages in 0-100 range only");
            }
        }

        static void CheckVowel()
        {
            // get character input form user and state whether it is an vowel or not

            char ch = char.Parse(Console.ReadLine());
            string s = ch.ToString().ToLower();

            switch (s)
            {
                case "a":
                    Console.WriteLine(s + " is a vowel");
                    break;
                case "e":
                    Console.WriteLine(s + " is a vowel");
                    break;
                case "i":
                case "o":
                case "u":
                    Console.WriteLine(s + " is a vowel");
                    break;
                default:
                    Console.WriteLine(s + " is not a vowel");
                    break;
            }
        }

        static void GetLoopEvenOddValues()
        {
            // to increment the counter from zero to 10. It should also display the even odd number along with the increment value.



            for (int i = 1; i <= 10; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an Even number");
                }
                else
                {
                    Console.WriteLine(i + " is an Odd number");
                }
            }
        }

        static void CheckprimeValueType1()
        {
            // get inputs form user and showcase whether it is a prime number or not using square root

            int num = int.Parse(Console.ReadLine());
            bool isprime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {

                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }

            }
            if (isprime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }


        }

        static void CheckprimeValueType2()
        {
            // get inputs form user and showcase whether it is a prime number or not

            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {

                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }

            }
            if (isprime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }

        static void CheckprimeValueType3()
        {
            bool isprime = true;
            int count = 0;
            int num = 1;
            int userinput = int.Parse(Console.ReadLine());

            while (count < userinput)
            {
                isprime = true;
                for (int a = 2; a < num; a++)
                {
                    if (num % a == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(num + "\t");
                    count++;
                }
                num++;
            }
        }

        static void First100PrimeNumbers()
        {
            // showcase 100 prime numbers

            for (int num = 1; num <= 100; num++)
            {
                bool isprime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                    Console.Write(num + "\t");

            }
            Console.WriteLine();
        }

        static void DisplayTable()
        {
            // get input number from user and showing table of that number till 10 values


            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * num;
                Console.WriteLine("{0} * {1} = {2}", num, i, result);
            }
        }

        static void DisplayTableTillGivenValue()
        {
            // get input number from user and showing table of number till you reach the input number table

            int num = int.Parse(Console.ReadLine());
            for (int a = 1; a <= num; a++)
            {

                for (int i = 1; i <= 10; i++)
                {
                    int result = i * a;
                    Console.WriteLine("{0} * {1} = {2}", a, i, result);
                }
                Console.WriteLine("--------------");
            }
        }

        static void CalculateDigits()
        {
            // calculating number of digits from given number from user

            int a = int.Parse(Console.ReadLine());
            int temp = a;
            int digit = 0;

            while (temp != 0)
            {
                temp = temp / 10;
                digit++;
            }
            Console.WriteLine("{0} is {1} digit number", a, digit);
        }

        static void LimitPinAttempts()
        {
            // accept only three attempts of input pin from user or else block the account

            string actualpin = "1234";
            string pinbyuser;
            int count = 0;

            do
            {
                pinbyuser = Console.ReadLine();
                count++;
            }
            while (pinbyuser != actualpin && count < 3);

            if (pinbyuser == actualpin)
            {
                Console.WriteLine("Welcome User");
            }
            else
            {
                Console.WriteLine("Account Block");
            }
        }

        static void RetryPinAttempts()
        {
            // accept only three attempts of input pin from user, show the number of failed attempts and after 3 attempts block the account

            string actualpin = "9876";
            string pinbyuser;
            int count = 0;

            do
            {
                pinbyuser = Console.ReadLine();
                count++;
                if (pinbyuser != actualpin)
                {
                    Console.WriteLine("Attempt {0} failed, please try again", count);
                }
            }

            while (pinbyuser != actualpin && count < 3);
            if (pinbyuser == actualpin)
            {
                Console.WriteLine("Welcome User");
            }
            else
            {
                Console.WriteLine("Account Block");
            }
        }

        static void FizzBuzzProgramType1()
        {

            // fizz buzz program in which multiple of 3,5 will be displayed fizz and buzz respectively and number which is multiple of both will be displayed as fizzbuzz

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void FizzBuzzProgramType2()
        {

            // fizz buzz program in which multiple of 3,5 will be displayed fizz and buzz respectively and number which is multiple of both will be displayed as fizzbuzz

            string output = null;
            int counter = 1;
            while (counter <= 100)
            {
                if (counter % 3 == 0)
                {
                    output = "Fizz";
                }
                else if (counter % 5 == 0)
                {
                    output = output + "Buzz";
                }
                else if (output == null)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(output);
                }

                counter++;
            }
        }
    }
}