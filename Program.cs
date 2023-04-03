// See https://aka.ms/new-console-template for more information
using System;
namespace TinhChiSoBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            Console.WriteLine("Please enter a height");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            weight = double.Parse(Console.ReadLine());

            double bmi;
            bmi  = weight / Math.Pow(height/100,2);
            
            
            Console.Write("BMI: "+ bmi);

            if (bmi < 18)
                Console.WriteLine(" Thieu can");
            else if (bmi < 25.0)
                Console.WriteLine(" Binh Thuong");
            else if (bmi < 30.0)
                Console.WriteLine(" Thua can");
            else
                Console.WriteLine(" Beo Phi");
        }
    }
}