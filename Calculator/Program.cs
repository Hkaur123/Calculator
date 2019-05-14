using System;
using System.Collections.Generic;
using Calculator.Bussiness;

class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator");
        Console.WriteLine("-------------------------");

        int firstNumber = ReadNumber("Enter your first number");
        int secondNumber = ReadNumber("Enter your Second number");
        string operator1 = ReadOperator();                
        Calculator.Bussiness.Calculator.PerformOperation(firstNumber, secondNumber, operator1);       

    }

    public static int ReadNumber(string text)
    {
        Console.WriteLine(text);
        string number = Console.ReadLine();
        while (!ValidateInput(number))
        {
            number = Console.ReadLine();
        }
        return int.Parse(number); 
    }

    public static string ReadOperator()
    {
        Console.WriteLine("Enter the operation you want to perform :Select operations from :  + , - , % ,/");
        string Operator=Console.ReadLine();
        while (!ValidateOperator(Operator))
        {
            Operator = Console.ReadLine();
        }
        return Operator;
    }

    

    public static bool ValidateInput(string number)
    {
        int n;
        bool isNumber = int.TryParse(number, out n);
        if (!isNumber)
        {
            Console.WriteLine("Enter a valid number");            
            return false;
        }
        else
        {
            return true;
        }


    }

    public static bool ValidateOperator(string Operator)
    {
       
        List<string> operators = new List<string> { "+", "*", "%", "/" };
        if (!operators.Contains(Operator))
        {
            Console.WriteLine("Enter a valid operator");
            return false;

        }
        else
        {
            return true;
        }
        

    }
}



