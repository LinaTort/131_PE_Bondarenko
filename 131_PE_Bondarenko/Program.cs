using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_Bondarenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount of revenue");
            double revenue = Convert.ToInt32(Console.ReadLine());
            double summ;
           
            if (revenue < 10000)
            {
                Console.WriteLine("revenue={0}", revenue);
            }
            if (revenue == 10000)
            {
                summ = (revenue / 100) * 5;
                Console.WriteLine("your revenues="+summ);
            }
            if (revenue > 10000)
            {
                summ =(((revenue - 10000) / 100 * 10)) + 500;
                Console.WriteLine("your revenues="+summ);
            }
            Console.ReadKey();
        }
    }
}
