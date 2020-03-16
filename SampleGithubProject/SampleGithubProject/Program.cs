using System;

namespace SampleGithubProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimal(13));
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

    }
}
