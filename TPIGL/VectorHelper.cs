using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIGL
{
    class VectorHelper
    {
        public int[] Som2Vect(int[] vect1,int[] vect2 )
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
            catch(exepTai e)
            {
                Console.WriteLine("Les deux tableaux n ont pas la meme taille, \nvous ne pouvez pas effectuer cette operation");
            }
            catch(Exception e)
            {
                Console.WriteLine("un des tableaux n existe pas");
            }
            return som;
        }
    }
}
