using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;
                Console.WriteLine( "enter the number");
           N =Convert.ToInt32(Console.ReadLine());
            for(M=1; M<=10; M++)
            {
                Console.WriteLine("{0}*{1}={2}",N,M,(N*M));

            }
            Console.ReadLine();
        }
    }
}
