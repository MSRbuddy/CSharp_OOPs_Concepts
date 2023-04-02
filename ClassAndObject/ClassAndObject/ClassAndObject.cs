﻿namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating object
            Calculator calObject = new Calculator();
            //Accessing Calculator class member using Calculator class object
            int result = calObject.CalculateSum(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    //Defining class or blueprint or template
    public class Calculator
    {
        public int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}