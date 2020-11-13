using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkyl2._0
{
    class Calc
    {
        public void Calcul8()
        {   
            // Ber om tre termer och två operatorer, räknar sedan ut resultatet somt skriver ut det
            // Kalkylatorn tar även hänsyn till om du använder * eller / för att det ska bli korrektverk

            Console.Write("Skiv in en term: ");
            double input1 = Convert.ToInt32(Console.Read());

            Console.WriteLine("Skiv in en operator: ");
            char oper8or1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Skiv in en till term: ");
            double input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skiv in en till operator: ");
            char oper8or2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Skiv in en till term: ");
            double input3 = Convert.ToInt32(Console.ReadLine());


            double result = 0;

            if (oper8or2 == '*')
            {
                result = input2 * input3;
                if (oper8or1 == '*')
                {
                    result = input1 * result;
                }
                else if (oper8or1 == '/')
                {
                    result = input1 / result;
                }
                else if (oper8or1 == '+')
                {
                    result = input1 + result;
                }
                else if (oper8or1 == '-')
                {
                    result = input1 - result;
                }
            }
            else if (oper8or2 == '/')
            {
                result = input2 / input3;
                if (oper8or1 == '*')
                {
                    result = input1 * result;
                }
                else if (oper8or1 == '/')
                {
                    result = input1 / result;
                }
                else if (oper8or1 == '+')
                {
                    result = input1 + result;
                }
                else if (oper8or1 == '-')
                {
                    result = input1 - result;
                }

            }
            else if (oper8or1 == '*')
            {
                result = input1 * input2;
                if (oper8or2 == '*')
                {
                    result *= input3;
                }
                else if (oper8or2 == '/')
                {
                    result /= input3;
                }
                else if (oper8or2 == '+')
                {
                    result += input3;
                }
                else if (oper8or2 == '-')
                {
                    result -= input3;
                }
            }
            else if (oper8or1 == '/')
            {
                result = input1 / input2;
                if (oper8or2 == '*')
                {
                    result *= input3;
                }
                else if (oper8or2 == '/')
                {
                    result /= input3;
                }
                else if (oper8or2 == '+')
                {
                    result += input3;
                }
                else if (oper8or2 == '-')
                {
                    result -= input3;
                }
            }
            else if (oper8or1 == '+')
            {
                result = input1 + input2;
                if (oper8or2 == '+')
                {
                    result += input3;
                }
                else if (oper8or2 == '-')
                {
                    result -= input3;
                }

            }
            else if (oper8or1 == '-')
            {
                result = input1 - input2;
                if (oper8or2 == '+')
                {
                    result += input3;
                }
                else if (oper8or2 == '-')
                {
                    result -= input3;
                }

            }
            Console.WriteLine($"{input1} {oper8or1} {input2} {oper8or2} {input3} = {result} ");
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att fortsätta, vill du avsluta skriv stop");
            string stop = Console.ReadLine();
            if (stop == "stop")
            {
                Environment.Exit(0);
            }
        }
    }
}
