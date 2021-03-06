using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MAX_3_Num_Day_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**UC1**");
            int output = MaxNumCheck.MaximumIntegerNumber(11, 9, 33);
            Console.WriteLine(output);
            Console.WriteLine("**UC2**");
            double doubleoutput = MaxNumCheck.MaximumFloatNumber(11.7, 92.47, 70.56);
            Console.WriteLine(doubleoutput);
            Console.WriteLine("**UC3**");
            string stringoutput = MaxNumCheck.MaximumStringNumber("apple", "peach", "grapes");
            Console.WriteLine(stringoutput);
            /*
                        Console.WriteLine("***UC4***");
                        int[] intArray = { 11, 3442, 4032, 55, 68 };
                        GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
                        generic.MaxMethod();
                        generic.PrintMaxValue();
                        double[] doubleArray = { 1.2, 340.4, 44.36, 51.55, 67.78 };
                        GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
                        generic.MaxMethod();
                        genericDouble.PrintMaxValue();
            */

            Console.WriteLine("***UC5***");
            int[] intArray = { 11, 342, 102, 55, 68 };
            GenericMax<int> generic = new GenericMax<int>(intArray);

            //generic.MaxMethod();
            generic.PrintMaxValue();

            double[] doubleArray = { 1.2, 34.4, 44.36, 51.55, 67.78 };
            GenericMax<double> genericDouble = new GenericMax<double>(doubleArray);
            //generic.MaxMethod();
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            GenericMax<string> genericString = new GenericMax<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadLine();
        }

    }
}