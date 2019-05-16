using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Bussiness
{
    public static class Calculator
    {

        public static double Add(double number1, double number2)
        {

            double sum = number1 + number2;
            return sum;
        }
        public static double Product(double number1, double number2)
        {
            double prod = number1 * number2;
            return prod;
        }
        public static double Divide(double number1, double number2)
        {
                double divide = number1 / number2;
                return divide;
        }
        public static double Subtract(double number1, double number2)
        {
            double subtract = number1 - number2;
            return subtract;
        }

        public static double Mod(double number1, double number2)
        {
            double mod = number1 % number2;
            return mod;
        }
        

        public static double PerformOperation(double number1, double number2, string operator1)
        {


            switch (operator1)
            {

                case "+":
                    double sum1 = Add(number1, number2);
                    Console.WriteLine("The sum of two numbers is {0}", sum1);
                    return sum1;
                   
                case "*":
                    double prod1 = Product(number1, number2);
                    Console.WriteLine("The product of two numebrs is {0}", prod1);
                    return prod1;
                case "/":
                    double div1 = Divide(number1, number2);
                    Console.WriteLine("The division of two numebrs is {0}", div1);
                    return div1;
                case "%":
                    double mod1 = Mod(number1, number2);
                    Console.WriteLine("The division of two numebrs is {0}", mod1);
                    return mod1;
                case "-":
                    double sub1 = Subtract(number1, number2);
                    Console.WriteLine("The subtraction of two numebrs is {0}", sub1);
                    return sub1;

                default:
                    return -1;


            }
        }

    }

}
