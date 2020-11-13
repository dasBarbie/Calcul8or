using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kalkyl2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calc Calculator = new Calc();
                Calculator.Calcul8();
            }
        }   
    }
}
