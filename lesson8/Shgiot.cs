using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
   public static class Shgiot
    {
        public static int ReadInt(string c = "enter numer ")
        {
            Console.WriteLine(c);
            string x = Console.ReadLine();
            int result;
            while (!int.TryParse(x, out result))
            {
                Console.WriteLine("enter num again");
                x = Console.ReadLine();
            }

            return result;
        }
    }
}
