using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kalkyl2._0
{
    class EkvationsLista
    {
        public void MyList(double x, double y, double z) 
        {
            List<double> Equations = new List<double>();
            double a = x + y + z;
            double b = x + y - z;
            double c = x + y * z;
            double d = x + y / z;
            double e = x - y + z;
            double f = x - y - z;
            double g = x - y * z;
            double h = x - y / z;
            double i = x * y + z;
            double j = x * y - z;
            double k = x * y * z;
            double l = x * y / z;
            double m = x / y + z;
            double n = x / y - z;
            double o = x / y * z;
            double p = x / y / z;
            Equations.Add(a);
            Equations.Add(b);
            Equations.Add(c);
            Equations.Add(d);
            Equations.Add(e);
            Equations.Add(f);
            Equations.Add(g);
            Equations.Add(h);
            Equations.Add(i);
            Equations.Add(j);
            Equations.Add(k);
            Equations.Add(l);
            Equations.Add(m);
            Equations.Add(n);
            Equations.Add(o);
            Equations.Add(p);

            Console.WriteLine(Equations[0]);
            Console.WriteLine(Equations[1]);
        }
    }
}
