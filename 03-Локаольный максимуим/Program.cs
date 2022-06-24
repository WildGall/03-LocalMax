using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Локаольный_максимуим
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            Random random = new Random();
            int maximumNumberInArray = 10;
            int minimumNumberInArray = 1;
            int stepArray = 1;
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(minimumNumberInArray, maximumNumberInArray);
                Console.Write(array[i] + " ");           
            }
            Console.WriteLine("\nЛокальные максимумы: ");

            for (int i = 0; i < stepArray; i++)
            {
                if (array[i] > array[i + stepArray])
                {
                    Console.Write(array[i] + " ");;
                }
            }

            for (int i = 1; i < arrayLength - stepArray; i++)
            {

                if (array[i] > array[i + stepArray] && array[i] > array[i - stepArray])
                {
                    Console.Write(array[i] + " ");
                }
            }            

            for (int i = arrayLength- stepArray; i < arrayLength; i++)
            {

                if (array[i] > array[i - stepArray])
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
