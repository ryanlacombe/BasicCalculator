using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string quitCalc = "";
            string operation = "";

            while (quitCalc != "q")
            {
                Console.WriteLine("What are we doing? (add/subtract/divde/multiply)");
                operation = Console.ReadLine();
                if (operation == "add" || operation == "Add")
                {
                    addCalc();
                }
                else if (operation == "subtract" || operation == "Subtract")
                {
                    subCalc();
                }
                else if (operation == "divide" || operation == "Divide")
                {
                    divideCalc();
                }
                else if (operation == "multiply" || operation == "Multiply")
                {
                    multiplyCalc();
                }
                quitCalc = Console.ReadLine();
            } 
            void addCalc()
            {
                Console.WriteLine("What is the first number?");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number?");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                int finalNum = firstNum + secondNum;
                Console.WriteLine(firstNum + " plus " + secondNum + " equals " + finalNum);
            }
            void subCalc()
            {
                Console.WriteLine("What is the first number?");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number?");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                int finalNum = firstNum - secondNum;
                Console.WriteLine(firstNum + " minus " + secondNum + " equals " + finalNum);
            }
            void divideCalc()
            {
                Console.WriteLine("What is the first number?");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number?");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                int finalNum = firstNum / secondNum;
                Console.WriteLine(firstNum + " divided by " + secondNum + " equals " + finalNum);
            }
            void multiplyCalc()
            {
                Console.WriteLine("What is the first number?");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the second number?");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                int finalNum = firstNum * secondNum;
                Console.WriteLine(firstNum + " multiplied by " + secondNum + " equals " + finalNum);
            }

        }
    }
}
