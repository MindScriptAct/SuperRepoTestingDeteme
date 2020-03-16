using System;

namespace SampleGithubProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindBiggestNumber(10, 20, 30));
            Console.WriteLine(TestNumberInRange(10, 0, 20));
        }

        static int FindBiggestNumber(int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3)
            {
                return number1;
            }
            if (number2 >= number3)
            {
                return number2;
            }
            return number3;
        }

        static bool TestNumberInRange(int testNumber, int minValue, int maxValue)
        {
            return testNumber >= minValue && testNumber <= maxValue;
        }

    }
}
