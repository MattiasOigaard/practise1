using System;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or type 'ok' to exit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of all numbers is: " + sum);
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
