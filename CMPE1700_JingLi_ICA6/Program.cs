using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700_JingLi_ICA6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(65);
            l.Add(51);
            l.Add(32);
            l.Add(9);
            l.Add(38);
            l.Add(329);
            int sum = 0;
            int s = sum_re(l.Count - 1, sum, l);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static int sum_re(int count, int sum, List<int> l)
        {
            if(l == null)
            {
                return 0;
            }
            else if (count == 0)
            {
                sum += l[count];
                return sum;
            }
            else
            {
                sum += l[count];
                return sum_re(count -= 1, sum, l);
            }
        }
    }
}
