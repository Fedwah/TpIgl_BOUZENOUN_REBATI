using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPIGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIGL.Tests
{
    [TestClass()]
    public class VectorHelperTests
    {
        VectorHelper Vh;
        public void VectorHelperTest()
        {
            
        }

        [TestMethod()]
        public void TRierVecteurTest()
        {
            Vh = new VectorHelper();
            int[] Vect1 = { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = { -6, 1, 2, 3, 4, 5, 7, 9 };
            Vh.TRierVecteur(Vect1);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void MUltipparnTest()
        {
            Vh = new VectorHelper();
            int[] Vect1 = { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = { 9, 15, 12, -18, 6, 3, 21, 27 };
            Vh.MUltipparn(Vect1,3);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void ADdnTest()
        {
            Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = new int[8] { 5, 7, 6, -4, 4, 3, 9,11 };
            Vh.ADdn(Vect1, 2);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void SOustrairenTest()
        {
            Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 = new int[8] { 1, 3, 2, -8, 0, -1, 5, 7 };
            Vh.SOustrairen(Vect1, 2);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void OpposeeTest()
        {
            Vh = new VectorHelper();
            int[] Vect1 = new int[8] { 3, 5, 4, -6, 2, 1, 7, 9 };
            int[] Vect2 =new int[8] { -3,-5,-4,6,-2,-1, -7, -9 };
            Vh.Opposee(Vect1);
            CollectionAssert.Equals(Vect1, Vect2);
        }

        [TestMethod()]
        public void Som2VectTest()
        {
           
        }

        [TestMethod()]
        public void swapTest()
        {
           
        }

        [TestMethod()]
        public void reverseTest()
        {
            
        }

        [TestMethod()]
        public void maxMinOfTableTest()
        {
           
        }
    }
}