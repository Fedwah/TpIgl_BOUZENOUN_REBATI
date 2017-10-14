using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_IGL
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] T1 = new int[20] { 5,4,1,9,10,600, 8,17, 33,92, 55, 54, 91, 99, 710, -6, 80, 7, 3, 2 };
            int[] T2 = new int[20];
            VectorHelper v = new VectorHelper();
            v.TRierVecteur(T1);
         
            for(int i=0;i<T1.Length;i++)
            {
                Console.WriteLine(T1[i]);
            }
            v.ADdn(T1, 5);
            for (int i = 0; i < T1.Length; i++)
            {
                Console.WriteLine(T1[i]);
            }
            v.MUltipparn(T1, 2);
            for (int i = 0; i < T1.Length; i++)
            {
                Console.WriteLine(T1[i]);
            }
            v.SOustrairen(T1, 4);
            for (int i = 0; i < T1.Length; i++)
            {
                Console.WriteLine(T1[i]);
            }

        }
    }
}
