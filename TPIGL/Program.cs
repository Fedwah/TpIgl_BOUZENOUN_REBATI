using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIGL
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] a = new int[] { 4, 5, 6 };
             int[] b = new int[] { 1, 2, 3,9 };
             int[] d = null;
             VectorHelper v = new VectorHelper();
             int[]c = v.Som2Vect(a, a);
             Console.WriteLine(c);
          


        }
    }
}
