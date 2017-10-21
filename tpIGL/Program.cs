using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpIGL
{
    /// <summary>
    /// Program contient la methode main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VectorHelper v = new VectorHelper();
            int[] t1 = new int[5] { 1, 2,3,4,5};
            int [] t2 =new int[6] {7,8,2,0,5,9};
            v.TRierVecteur(t2);
            for(int i=0;i<t2.Length;i++)
            {
                Console.WriteLine(t2[i]);
            }
            v.Som2Vect(t1, t2);
         

        }
    }
}
