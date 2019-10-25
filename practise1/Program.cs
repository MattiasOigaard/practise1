using System;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by a comma: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');
            int max = Convert.ToInt32(numbers[0]);

            foreach (string str in numbers)
            {
                int number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

        }

        static void Exersice4()
        {
            //int number = new Random().Next(1, 10);

            //Console.WriteLine("Number is " + number);
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Guess the number: ");
            //    int guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //    }
            //}
            //Console.WriteLine("You lost!");
        }

        static void Exersice3() 
        {
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("{0}! = {1}", number, factorial);
        }

        static void Exersice2() 
        {
            //int sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or type 'ok' to exit): ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("The sum of all numbers is: " + sum);
        }

        static void Exersice1() 
        {
            //int count = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}

            //Console.WriteLine("There are {0} numbers divisable by 3 between 1 and 100.", count);
        }
         
    }
}
