using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpIGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpIGL.Tests
{
    [TestClass()]
    public class VectorHelperTests
    {
        [TestMethod()]
        public void TRierVecteurTest()
        {
            VectorHelper Vh = new VectorHelper();
            int[] Vect1 = { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = { -6, 1, 2, 3, 4, 5, 7, 9 };
            Vh.TRierVecteur(Vect1);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void MUltipparnTest()
        {
           VectorHelper Vh = new VectorHelper();
            int[] Vect1 = { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = { 9, 15, 12, -18, 6, 3, 21, 27 };
            Vh.MUltipparn(Vect1, 3);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void ADdnTest()
        {
            VectorHelper Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = new int[8] { 5, 7, 6, -4, 4, 3, 9, 11 };
            Vh.ADdn(Vect1, 2);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void SOustrairenTest()
        {

            VectorHelper Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = new int[8] { 1, 3, 2, -8, 0, -1, 5, 7 };
            Vh.SOustrairen(Vect1, 2);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void OpposeeTest()
        {
            VectorHelper Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = new int[8] { -3, -5, -4, 6, -2, -1, -7, -9 };
            Vh.Opposee(Vect1);
            CollectionAssert.Equals(Vect1, Vect2);
        }
      
        [TestMethod()]

        
        public void Som2VectTest()
        {
            //test de la somme
            VectorHelper Vh = new VectorHelper();
            int[] vect1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] vect2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] vect3 = new int[3] { 11, 12, 13 };
            int[] expectedVect = new int[5] { 7, 9, 11, 13, 15 };
            vect1 = Vh.Som2Vect(vect1, vect2);
            CollectionAssert.Equals(vect1, expectedVect);
            // test des exceptions exeption de taille
            if (Vh.Som2Vect(vect1, vect3) != null) Assert.Fail();

            //exeption pour les tableaux null
             try
             {
                 Vh.Som2Vect(vect1, null);
                 Assert.Fail();
             }
             catch(Exception e)
             {
                 Assert.IsTrue(e is Exception);
             }

        }

        [TestMethod()]
        public void reverseTest()
        {
            VectorHelper Vh = new VectorHelper();
            int[] vect = new int[5] { 1, 2, 3, 4, 5 };
            int[] expectedvect = new int[5] { 5, 4, 3, 2, 1 };
            vect = Vh.reverse(vect);
            CollectionAssert.Equals(vect, expectedvect);

        }

        [TestMethod()]
        public void maxMinOfTableTest()
        {
            VectorHelper Vh = new VectorHelper();
            int[] vect = new int[5] { 4, 8, 9, 10, 0 };
            int[] maxMin = Vh.maxMinOfTable(vect);
            int[] expectedResult = new int[2] { 10, 0 };
            CollectionAssert.Equals(maxMin, expectedResult);
        }

       
    }
}