using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6211_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] searchArray = new int[50];
            Random random = new Random();
            for (int i = 0; i < searchArray.Length; i++)
                searchArray[i] = random.Next(0, 10);

            Console.WriteLine(PlusOneUntil(5, 1));

            Console.WriteLine();

            Console.WriteLine(NumbersBetween(5, 10));

            Console.WriteLine();

            for (int i = 0; i < searchArray.Length; i++)
                Console.Write(searchArray[i] + " ");

            Console.WriteLine("\nIndex of found value: " + RecursiveSearch(0, searchArray, 5));

            Console.WriteLine();

            Console.WriteLine("\n" + FactorialRecursion(5));

            Console.WriteLine();

            int[] numbers = new int[30];
            numbers = FibonacciSequence(numbers, 0);
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
                
            
            Console.ReadLine();

        }

        private static int PlusOneUntil(int until, int total)
        {
            if (total == until)
                return total;

            total++;

            return PlusOneUntil(until, total);
        }

        private static int NumbersBetween(int min, int max)
        {
            if (min == max)
                return max;

            Console.WriteLine(min);

            min++;

            return NumbersBetween(min, max);
        }

        private static int RecursiveSearch(int index, int[] searchArray, int value)
        {
            if (index == searchArray.Length)
                return -1;

            if (searchArray[index] == value)
                return index;

            index++;

            return RecursiveSearch(index, searchArray, value);
        }

        private static int FactorialRecursion(int fNum)
        {
            if (fNum == 1)
                return 1;

            return fNum * FactorialRecursion(fNum - 1);
        }

        private static int[] FibonacciSequence(int[] numbers, int index)
        {
            if (index >= numbers.Length)
                return numbers;

            if (index > 1)
                numbers[index] = numbers[index - 1] + numbers[index - 2];
            else if (index == 1)
                numbers[index] = 1;
            else
                numbers[index] = 0;

            return FibonacciSequence(numbers, ++index);
        }

    }
}
