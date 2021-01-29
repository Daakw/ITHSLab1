using System;
using System.Collections.Generic;
using System.Numerics;

namespace ITHSLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Parkodat med Markus Johansson.



            Console.WriteLine("\nSkriv in en sträng bestående av siffror och karaktärer: \n");
            string inPut = Console.ReadLine();

            List<string> SumOf = new List<string>();

            
            for (int startIndex = 0; startIndex < inPut.Length - 1; startIndex++)
            {
                char Dgit = inPut[startIndex];

                for (int endIndex = startIndex + 1; endIndex < inPut.Length; endIndex++)
                {
                    

                    if (!char.IsDigit(inPut[endIndex]))
                    {
                        break;
                    }

                    if (Dgit == inPut[endIndex])
                    {
                        PrintColourCh(inPut, startIndex, endIndex);
                        SumOf.Add(inPut.Substring(startIndex, endIndex - startIndex + 1));

                        break;

                    }


                }

            }


            Console.WriteLine($"\nSumman av alla delsträngar: {ResultOfList(SumOf)}");

            Console.ReadKey();


        }
        public static void PrintColourCh(string inPut, int startIndex, int endIndex)
        {

            string s1 = inPut.Substring(0, startIndex);
            string s2 = inPut.Substring(startIndex, endIndex - startIndex + 1);
            string s3 = inPut.Substring(endIndex + 1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(s2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s3);

        }
        public static BigInteger ResultOfList(List<string> SumTotal)
        {

            BigInteger SumOff = 0;

            for (int i = 0; i < SumTotal.Count; i++)
            {
                SumOff += BigInteger.Parse(SumTotal[i]); 
            }

            return SumOff;
        
        }
    }
}