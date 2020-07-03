
using System;

namespace App34
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numCount = 0;
            string input;
            double[] value = new double[10];
            double num;
            do
            {
                input = Console.ReadLine();
                if (double.TryParse(input, out num) && num >= 0)
                {
                    for (int i = numCount; i <= numCount; i++)
                    {
                        value[i] = num;
                    }

                    numCount++;
                }
            } while (!(input == "x"));
            for (int i = 0; i < numCount; i++)
                Console.WriteLine("{0}", (value[i].ToString()));
            if(numCount==0)
                Console.WriteLine("N/A");
        }
    }
}
