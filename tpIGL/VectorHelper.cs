using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpIGL
{
    class VectorHelper
    {

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


