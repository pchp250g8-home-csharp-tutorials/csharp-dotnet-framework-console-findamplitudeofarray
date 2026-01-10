using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAmplitudeOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oRnd = new Random();
            Console.WriteLine("Input a count of elements:");
            int.TryParse(Console.ReadLine(), out var nElems);
            if (nElems == 0)
            {
                Console.WriteLine("Empty arrays not allowed");
                Console.Read();
                return;
            }
            Console.WriteLine($"Generating array by filling {nElems}:");
            int[] iNumbers = new int[nElems];
            for (int i = 0; i < nElems; i++)
            {
                iNumbers[i] = oRnd.Next(1, 100);
                Console.Write(iNumbers[i] + " ");
            }
            var iMax = iNumbers[0];
            var iMin = iNumbers[0];
            var nMaxIndex = 0;
            var nMinIndex = 0;
            for (int i = 1; i < nElems; i++)
            {
                if (iNumbers[i] > iMax)
                {
                    iMax = iNumbers[i];
                    nMaxIndex = i;
                }
                if (iNumbers[i] < iMin)
                {
                    iMin = iNumbers[i];
                    nMinIndex = i;
                }

            }
            Console.WriteLine($"\r\nFound maximum element: {iMax} with index {nMaxIndex}");
            Console.WriteLine($"Found minimum element: {iMin} with index {nMinIndex}");
            Console.WriteLine($"Found amplitude: {iMax - iMin}");
            Console.Read();
        }
    }
}
