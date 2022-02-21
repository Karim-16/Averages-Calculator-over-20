using System;
using System.Collections.Generic;
using System.Linq;

namespace app_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finishTyping = false;
            float input;
            string inputString = "";
            Console.WriteLine("Introduce minimum grade to pass: ");
            double min2Pass = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce grades: ");


            List<float> promNum = new List<float>();

            while (!finishTyping)
            {
                inputString = Console.ReadLine();

                if (inputString == "done")
                    finishTyping = true;
                else
                {
                    try
                    {
                        input = float.Parse(inputString);
                        promNum.Add(input);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Invalid input, please only use integers!");
                    }
                }
            }

            int sum = promNum.ConvertAll(Convert.ToInt32).Sum();
            Console.WriteLine("*");
            foreach (float value in promNum)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("*");

            Console.WriteLine("Sum of all inputs: " + sum);
            Console.WriteLine("number of inputs registered: " + promNum.Count);
            int valuesCount = promNum.Count;

            Console.WriteLine("Average: " + promNum.Sum() / valuesCount);

            int prom = Convert.ToInt32(promNum.Sum() / valuesCount);
            int promValue = Convert.ToInt32(promNum.Sum());
            double min = promNum.Min();
            int examsNums = promNum.Count;
            //  aaa = ((20*conteoDeEntradas)-promNum.Sum());

            double Xnum = (promNum.Count + 1) * min2Pass - promNum.Sum();

            //sustitutorio para x numero

            //double XnumSus = ((4.5 * valuesCount) + min);
            double A = promValue-min;
            double XnumSus = (min2Pass*examsNums-A);

            if ((promNum.Sum() / valuesCount) < min2Pass)
            {
                Console.WriteLine("---Dissaproved---");
                Console.WriteLine("Necesitas: " + Xnum + " para pasar el curso");
                Console.WriteLine("Sustitutoria necesitada: " + XnumSus);
            }
            else
            {
                Console.WriteLine("---Aproved---");
                Console.WriteLine("pipo");

                Console.ReadKey();
            }

            //int extrapolation = 0;

        }
    }
}


