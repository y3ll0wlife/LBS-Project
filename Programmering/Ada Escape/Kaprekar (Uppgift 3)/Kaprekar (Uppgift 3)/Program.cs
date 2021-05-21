using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprekar__Uppgift_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "3141"; // Testing
            int n = 1;
            //string str = "1917"; // 4
            //string str = "7430"; // 5
            //string str = "8833"; // 7
            //string str = "9998"; // 7
            // 4577
            while (n != 10)
            {
                string low = String.Concat(str.OrderBy(c => c));
                string high = String.Concat(str.OrderByDescending(c => c));
                int newNum = Convert.ToInt32(high) - Convert.ToInt32(low);
                str = newNum.ToString();
                if (str.Length == 3) str = "0" + str;
                Console.WriteLine("Rounds: " + n +  "    " + high + " - " + low + " = " + str);
                n++;
                
            }
            Console.ReadKey();
        }
    }
}
