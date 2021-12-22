using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAB2
{
    class Code
    {
        static void Main(string[] args)
        {
            Console.WriteLine(funks.funks.Power(5, 2));
            Console.WriteLine(Math.Pow(5, 2));


            double a = Math.Log(1024, 2);
            double b = Math.Log(1024) / Math.Log(2);


            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine(Math.Log(100));
            Console.WriteLine(funks.funks.Power(5, 2));
            Console.WriteLine("\n\n");
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if (x <= 0)
            {
                result = (((funks.funks.Power((funks.funks.Power(funks.funks.Cos(x),3) + funks.funks.Ctan(x)),2) - funks.funks.cosec(x)) - funks.funks.Cos(x)));
            }
            else
            {
                result = ((((funks.funks.Power(funks.funks.Log_10(x,10)/ funks.funks.Log_5(x,5),3) + (funks.funks.Log_2(x,2) + funks.funks.Log_5(x,5))) - (funks.funks.Power(funks.funks.Ln(x),3)/ funks.funks.Log_3(x,3))) - (funks.funks.Log_2(x,2) + funks.funks.Log_5(x,5))));
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
