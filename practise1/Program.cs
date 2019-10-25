using System;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write your name: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@echo: " + input);
                    continue;
                }

                    break;

                                                                                        
            }
        }
    }
}
