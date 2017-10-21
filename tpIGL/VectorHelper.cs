using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpIGL
{
    /// <summary>
    /// la classe VectorHelper contient des methodes sur les vecteurs
    /// </summary>
    public class VectorHelper
    {
        
       

        /// <summary>
        ///  TRierVecteur : cette methode trie un tableau à 1 dimension en utilisant le trie par bulle
        /// </summary>
        /// <param name="vecteuratrier"></param>
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
        /// <summary>
        /// multiplie les valeurs de votre tableau en entré par un nombre choisi n
        /// </summary>
        /// <param name="vecteuratriter"></param>
        /// <param name="n"></param>
        public void MUltipparn(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] * n;
            }
        }
        /// <summary>
        /// la methode ADdn ajoute le nombre n a toute les cases de votre tableau
        /// </summary>
        /// <param name="vecteuratriter"></param>
        /// <param name="n"></param>
        public void ADdn(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] + n;
            }
        }
        /// <summary>
        /// la methode SOustrairen utilisée pour soustraire le nombre choisi n des valeurs de votre tableau
        /// </summary>
        /// <param name="vecteuratriter"></param>
        /// <param name="n"></param>
        public void SOustrairen(int[] vecteuratriter, int n)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] - n;
            }
        }
        /// <summary>
        /// Opposee vous donne les valeurs inverses de votre tableau en les multipliant par -1
        /// </summary>
        /// <param name="vecteuratriter"></param>
        public void Opposee(int[] vecteuratriter)
        {
            for (int i = 0; i < vecteuratriter.Length; i++)
            {
                vecteuratriter[i] = vecteuratriter[i] * -1;
            }
        }



        /// <summary>
        /// la methode som2vecteur somme deux tableaux a une dimension 
        /// le resultat c est un tabeau ou chaque case est la somme des deux cases qui ont le meme indexe que cette derniere.
        /// Une exeption exepTai est declenchée si vous essayez de sommer deux tableaux de taille differente 
        /// et une autre exeption si vous mettez un vecteur nulle en entré
        /// </summary>
        /// <param name="vect1"></param>
        /// <param name="vect2"></param>
        /// <returns></returns>

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

        /// <summary>
        /// La methode reverse inverse les elements du tableau : les valeurs commencent par la fin 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public int[] reverse(int[] table)
            {
                int start, end;
                for (start = 0, end = table.Length - 1; start < (table.Length /2); start++, end--)
                {
                    int permute = table[start];
                    table[start] = table[end];
                    table[end] = permute;

                }
                return table;
            }
        /// <summary>
        /// la methode maxMinOfTable donne la valeur maximale et minimale du tableau en entré
        /// retourne un tableau de taille 2 ou la premiere case represente le max et la deuxième
        /// le min
        /// </summary>
        /// <param name="table"></param>
        public int [] maxMinOfTable(int[] table)
            {
                int max = table[0];
                int min = table[0];
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] > max) max = table[i];
                    if (table[i] < min) min = table[i];
                }
            int[] maxMin = new int[2] { max, min };
            return maxMin;
            }
 
        }

    }
    



