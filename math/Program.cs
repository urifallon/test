using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int select;
            do
            {
                Console.WriteLine("Select: ");
                Console.WriteLine("1. hinh chu nhat");
                Console.WriteLine("2. hinh tron");
                select = Convert.ToInt32(Console.ReadLine());
            } while (select != 0);
        }
    }
}
