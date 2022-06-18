using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.Readline());
            Console.WriteLine("Enter Favourite Color");
            string favouriteColor = Console.ReadLine();
            Console.WriteLine("Favourite Food");
            string favouriteFood = Console.ReadLine();
            Console.WriteLine("Enter stateOfOrigin");
            string stateOfOrigin = Console.ReadLine();

            /*Console.Write("My name is ");
            Console.Write(firstName + " " + lastName );
            Console.Write("from ");
            Console.Write(stateOfOrigin);
            Console.Write("I am ");
            Console.Write(age);
            Console.Write(" years old.");
            Console.Write(" My favorite food is ");
            Console.Write(favouriteFood); 
            Console.Write(" and my favourite color is ");
            Console.Write(favouriteColor);
            Console.Write(".");*/

            /*string result1 = $"My name is {firstName} {lastName} I am from {stateOfOrigin}. I am {age} years old. My favorite food is {favouriteFood} and my favorite color is {favouriteColor}.";

            string result2 = "My name is "+ firstName + " " + lastName + " " + "I am from " + stateOfOrigin + ".\n" + "I am "+ age + " years old. My favorite food is " + favouriteFood + " and my favorite color is " + favouriteColor + "."; 


            /*Console.WriteLine(result1);
            Console.WriteLine(result2);

            /*int age = 12
            Console.WriteLine(age==18);
            Console.WriteLine(age < 18);*/
            
            /*int num = 12;
            double num2 = num;

            string myDouble = "78.98";
            double num3 = Convert.ToDouble(mydouble);
            int myint = (int)num3;
            Console.WriteLine(myint);
            Console.WriteLine(num3);*/

           /* Expression
            int r = (150 -2)/ 2 +5;
            double perimeter = 2 * Math.PI *r;*/
            
            Console.Write(());
            int 12
            Convert.Toint32(Console.ReadLine());
            if(number %2==0);
            Console.WriteLine(0 is an evennumber);



            			/*
             * Write an expression that checks whether an integer is odd or even.
             */
            Console.WriteLine("-------------------------------Question 1----------------------------------");
            Console.WriteLine("=====\nWrite an expression that checks whether an integer is odd or even.\n=====\n");
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number} is odd? {number % 2 != 0}");
            Console.WriteLine($"The number: {number} is even? {number % 2 == 0}");
            Console.WriteLine();

            /*
             *  Write a Boolean expression that checks whether a given integer is 
             *  divisible by both 5 and 7, without a remainder
             */
            Console.WriteLine("-------Question 2-------");
            Console.WriteLine("=====\nWrite a Boolean expression that checks whether a\ngiven integer is divisible by both 5 and 7, without a remainder\n=====\n");
            Console.Write("Enter the number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number2} is divisible by 5 and 7? {(number2 % 5 == 0) && (number2 % 7 == 0)}");
            Console.WriteLine();

            /*
             * Write an expression that calculates the area of a trapezoid by given 
             * sides a, b and height h.
             * 
             * Given that  S = (a + b) * h / 2
             */
            Console.WriteLine("-------Question 3-------");
            Console.WriteLine("=====\nWrite an expression that calculates the area of a trapezoid by given sides a, b and height h.\n\nGiven that  S = (a + b) * h / 2\n=====\n");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double S = (a + b) * h / 2;

            Console.WriteLine($"The area of the trapezoid of a = {a} b = {b} and h = {h} is: {S}");
            Console.WriteLine();


            /*
             *  The gravitational field of the Moon is approximately 17% of that on the 
             *  Earth. Write a program that calculates the weight of a man on the 
             *  moon by a given weight on the Earth.
             */
            Console.WriteLine("-------Question 4-------");
            Console.WriteLine("=====\nThe gravitational field of the Moon is approximately 17% of that on the Earth.\nWrite a program that calculates the weight of a man on the moon by a given weight on the Earth.\n=====\n");
            Console.Write("Enter the weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double percentGiven = 17d / 100;
            Console.WriteLine($"The weight of the man on the moon with {weight} on earth is: {weight * (percentGiven)}");
            Console.WriteLine();


            /*
             * Write a program that takes as input a four-digit number in format abcd
             * (e.g. 2011) and performs the following actions:
             * - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
             * - Prints on the console the number in reversed order: dcba (in our example 1102).
             * - Puts the last digit in the first position: dabc (in our example 1201).
             * - Exchanges the second and the third digits: acbd (in our example 2101).
             */
            Console.WriteLine("-------Question 5-------");
            Console.WriteLine("=====\nWrite a program that takes as input a four-digit number in format abcd\n(e.g. 2011) and performs the following actions:\n- Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).\n- Prints on the console the number in reversed order: dcba(in our example 1102).\n- Puts the last digit in the first position: dabc(in our example 1201).\n- Exchanges the second and the third digits: acbd(in our example 2101).\n=====\n");
            Console.Write("Enter a four digit number: ");
            string num = Console.ReadLine();
            int first = Convert.ToInt32(num[0].ToString());
            int second = Convert.ToInt32(num[1].ToString());
            int third = Convert.ToInt32(num[2].ToString());
            int fourth = Convert.ToInt32(num[3].ToString());

            Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
            Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");




        }
    }
}