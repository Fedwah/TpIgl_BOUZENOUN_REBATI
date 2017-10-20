using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpIGL
{
    class VectorHelper
    {
<<<<<<< HEAD
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
=======

            private int max;
            private int min;

         
            public int[] Som2Vect(int[] vect1, int[] vect2)
            {
                int[] som = null;
                try
                {

                    if (vect1.Length == vect2.Length)
                    {
                        som = new int[vect1.Length];
                        for (int i = 0; i < vect1.Length; i++)
                        {

                            som[i] = (int)vect1.GetValue(i) + (int)vect2.GetValue(i);

                        }

                    }
                    else
                    {
                        throw new exepTai();
                    }
                }
                catch (exepTai e)
                {
                    Console.WriteLine("Les deux tableaux n ont pas la meme taille, \nvous ne pouvez pas effectuer cette operation");
                }
                catch (Exception e)
                {
                    Console.WriteLine("un des tableaux n existe pas");
                }
                return som;
            }

            
            public int[] reverse(int[] table)
            {
                int start, end;
                for (start = 0, end = table.Length - 1; start < (table.Length / 2); start++, end--)
                {
                    int permute = table[start];
                    table[start] = table[end];
                    table[end] = permute;

                }
                return table;
            }
            
            public void maxMinOfTable(int[] table)
            {
                this.max = table[0];
                this.min = table[0];
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] > this.max) this.max = table[i];
                    if (table[i] < this.min) this.min = table[i];
                }
            }
           
            public int getMax()
            {
                return (this.max);
            }
            
            public int getMin()
            {
                return this.min;
            }
        }
    }


>>>>>>> origin/partie_fedwa
