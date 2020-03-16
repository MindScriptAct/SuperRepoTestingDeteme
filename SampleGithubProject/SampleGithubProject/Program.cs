using System;

namespace SampleGithubProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimal(13)); 
            Console.WriteLine(D20());
        }

        static bool IsPrimal(int number)
        {
            for (int i = 2; i < number / i; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int D20()
        {
            Random rnd = new Random();
            return rnd.Next(1, 21);
        }

    }
}
