using System;

namespace BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string weight;
            string height;
            double mass;

            double height_2;
            double weight_2;
            double bmi;
            Console.WriteLine("Enter your weight in Kilograms");
            weight = Console.ReadLine();
            Console.WriteLine("enter your height in metres");
            height = Console.ReadLine();
            weight_2 = Convert.ToDouble(weight);
            height_2 = Convert.ToDouble(height);

            mass = height_2 * height_2;
            bmi = weight_2 / mass  ;
            Console.WriteLine("your bmi is {0:00.00}" , bmi);

        }
    }
}
