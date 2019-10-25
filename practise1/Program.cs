using System;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers divisable by 3 between 1 and 100.", count);
        }
         
    }
}
