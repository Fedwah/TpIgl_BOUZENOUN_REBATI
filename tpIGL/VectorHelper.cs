using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpIGL
{
    class VectorHelper
    {
        public void TRierVecteur(int[] vecteuratrier)//Tri par bulle
        {


            int i; bool perm; int inter;
            do
            {
                perm = false;

                for (i = 0; i < vecteuratrier.Length - 1; i++)
                {
                    if (vecteuratrier[i] > vecteuratrier[i + 1])
                    {
                        inter = vecteuratrier[i];
                        vecteuratrier[i] = vecteuratrier[i + 1];
                        vecteuratrier[i + 1] = inter;
                        perm = true;
                    }

                }
            } while (perm);

        }
        
        public void MUltipparn(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] * n;
            }
        }
        
        public void ADdn(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] + n;
            }
        }
        
        public void SOustrairen(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] - n;
            }
        }
        
        public void Opposee(int[] vecteuratriter)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] * -1;
            }
        }
    }
}
