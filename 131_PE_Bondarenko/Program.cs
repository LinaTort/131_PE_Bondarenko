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
            int mrot = 300;//для 2 задания
            if (revenue <= mrot)
            {
                revenue = mrot;
                Console.WriteLine("your revenues=" + revenue);
            }
            if (revenue < 10000 && revenue > 300)//второе условие нужно для задания 2
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
