using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //OneThousandtoNegative();

            //UpByThree();

            //AreTwoNumbersTheSame(5, 7);

            //EvenOrOdd(28);

            //PositiveOrNegative(-7);

            //Console.WriteLine("What is your age?");

            //int age = int.Parse(Console.ReadLine());

            //CanVote(age);

            //Console.WriteLine("Please enter a number:");
            //int userInput = int.Parse(Console.ReadLine());
            //InRange(userInput);


        }


        //1.
        //method will print all numbers 1000 to -1000 to console
        public static void OneThousandtoNegative()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //2.
        // will print numbers by 3 from 3 to 999 to console.
        public static void UpByThree()

        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);   
            }
        }

        //3.
        //takes two integers as params and checks to see if they are equal.
        public static bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("These are equal");
                return true;
            }
            else
            {
                Console.WriteLine("Not the same!");
                return false;
            }
        }


        //4.
        //will check number to see if it is even or odd
        public static bool EvenOrOdd(int num1)
        { 

            if (num1 % 2 == 0)
            {
                Console.WriteLine("That's Even Stevens!");
                return true;
            }
            else
            {
                Console.WriteLine("That's an Odd Ball!");
                return false;
            }
        }

        //5
        //will check to see if number is positive or negative
        public static bool PositiveOrNegative(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("Positive!");
                return true;
            }
            else
            {
                Console.WriteLine("Negative");
                return false;
            }
        }

        //6
        //will check to see if candidate is old enough to vote.
        public static bool CanVote(int age)
        {

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
                return true;


            }
            else
            {
                Console.WriteLine($"You are not old enough to vote. Please come back in {18 - age} years");
                return false;
            }

        }

        public static bool InRange(int num1)
        {
            if (num1 <= 10 && num1 >= -10)
            {
                Console.WriteLine("In Range.");
                return true;
            }
            else
            {
                Console.WriteLine("Out of range");
                return false;
            }



        }
    }


    
}

