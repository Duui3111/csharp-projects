using System;

namespace Calculator
{
    class Program
    {     
        static void Main(string[] args)
        {   
            Console.Write("Calculator: ");

            string input = Console.ReadLine();

            double num1 = double.Parse(input.Split(" ")[0]);
            double num2 = double.Parse(input.Split(" ")[2]);

            string operation = input.Split(" ")[1];

            if(operation == "+") Console.WriteLine($"result: " + (num1 + num2));       
            else if(operation == "/") Console.WriteLine($"result: " + (num1 / num2));                
            else if(operation == "*") Console.WriteLine($"result: " + (num1 * num2));                 
            else if(operation == "-") Console.WriteLine($"result: " + (num1 - num2));
            
            Console.ReadKey();
        }
    }
}
