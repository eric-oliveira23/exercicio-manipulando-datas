using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulandodatas2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data;

            

            Console.WriteLine("A primeira parcela irá ser ");
            data = DateTime.Parse(Console.ReadLine()); 

            Console.WriteLine("A segunda parcela irá ser: "+data.AddMonths(1));
           

            Console.WriteLine("A terceira parcela irá ser: "+data.AddMonths(2));
            

            Console.WriteLine("A quarta parcela irá ser: "+ data.AddMonths(3));
            

            Console.ReadKey();






        }
    }
}
