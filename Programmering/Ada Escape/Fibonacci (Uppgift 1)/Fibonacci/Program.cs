/*
 Nivå 1 – Fibonacci

Du känner säker redan till Fibonacci-talserien. Det är ett mönster av tal som uppstår om du skapar nästa tal som en summa av de två tidigare talen i serien. Om serien börjar på talen 0 och 1 så blir de följande talen:

    1, 2, 3, 5, 8, 13, 21, 34, 55, 89, … 

Men vad blir summan av alla tal i serien om du summerar alla jämna termer under 2 miljoner?

Svaret ger dig tillgång till nästa nivå.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int lastNum = 1;
            int num = 0;
            int total = 0;
            int sum = 0;

            for (int i = 1; i <= 100000; i++)
            {
                total = lastNum + num;
                lastNum = num;
                num = total;
                if (num % 2 == 0) sum += num;
                if (num >= 2000000) break;
                
            }

            Console.WriteLine(sum); // 1089154
            Console.ReadKey();
        }
    }
}
