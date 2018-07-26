using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Ducci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int numberOfTuple = Convert.ToInt32 (Console.ReadLine());
            List<int> DucciList = new List<int>();

            for (int i = 0; i<numberOfTuple; i++)               //Add numbers to ducci sequnce array
            {
                DucciList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int count = 0;

            while (DucciList.Sum() != 0)
            {
                count++;
                int first = DucciList[0];
                for (int i = 0; i < numberOfTuple-1; i++)
                {
                        DucciList[i] = Math.Abs(DucciList[i] - DucciList[i + 1]);
                }
                DucciList[numberOfTuple - 1] = Math.Abs(DucciList[numberOfTuple - 1] - first);
            }

            for (int i = 0; i < numberOfTuple; i++)
            {
                Console.Write(DucciList[i] + "   ");
            }

            Console.WriteLine("Steps: " + count);

            Console.ReadKey();
        }
    }
}
