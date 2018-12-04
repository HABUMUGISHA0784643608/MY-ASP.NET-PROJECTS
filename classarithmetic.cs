using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Classarithmetic
    {
         public double number1;
        public double number2;
        public double addition(double number1, double number2){
            return (number1+number2);
        }
        public double subtruction(double number1, double number2){
            return (number1-number2);
        }
        public double multiplication(double number1, double number2){
            return (number1*number2);
        }
        public double division(double number1, double number2){
            if (number2==0)
            Console.WriteLine("it is impossible to divide any number by zero");
            return (number1/number2); 
        }

        public void operators()
        {
            Console.WriteLine("addition");
            Console.WriteLine("subtruction");
            Console.WriteLine("multiplication");
            Console.WriteLine("division");
        }
    }
}
