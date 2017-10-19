using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIGL
{
    public class VectorHelper
    {
        public VectorHelper()
        {

        }
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
        public void swap(int v1,int v2)
            {
            int permute = v2;
            v2 = v1;
            v1 = permute;
            }
        public int[] reverse(int[] table)
        {
            int start, end;
            for (start = 0,end = table.Length;start < (table.Length / 2);start++,end--)
            {
                swap(table[start], table[end]);
            }
            return table;
        }
        public  void maxMinOfTable(int[] table,int max,int min)
        {
            max = table[0];
            min = table[0];
            for(int i=1;i<table.Length;i++)
            {
                if (table[i] > max) max = table[i];
                if (table[i] < min) min = table[i];
            }
        }
    }
}
