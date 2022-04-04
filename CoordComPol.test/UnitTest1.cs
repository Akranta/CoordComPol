using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using coord;

namespace CoordComPol.test
{
    [TestClass]
    public class UnitTest_Complex
    {
        double[] a_real = new double[5] { 1, 0, 0, -10, 0.2 };
        double[] a_img = new double[5] { 3, 10, 0, -20, 0.45 };

        double[] b_real = new double[5] { 2, -1, 0, -30, -0.2 };
        double[] b_img = new double[5] { 5, 45, 0, -45, 0.77 };

        [TestMethod]
        public void Test_Complex_Plus()
        {
            double[] answ_real = new double[5] { 3, -1, 0, -40, 0 };
            double[] answ_img = new double[5] { 8, 55, 0, -65, 1.22 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_b = new Complex(b_real[i], b_img[i]);
                Complex account_c = account_a + account_b;
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_Minus()
        {
            double[] answ_real = new double[5] { -1, 1, 0, 20, 0.4 };
            double[] answ_img = new double[5] { -2, -35, 0, 25, -0.32 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_b = new Complex(b_real[i], b_img[i]);
                Complex account_c = account_a - account_b;
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_Multiply()
        {
            double[] answ_real = new double[5] { -13, -450, 0, -600, -0.38650 };
            double[] answ_img = new double[5] { 11, -10, 0, 1050, 0.06400 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_b = new Complex(b_real[i], b_img[i]);
                Complex account_c = account_a * account_b;
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_Div()
        {
            double[] answ_real = new double[5] { 0.58621, 0.22211, 0, 0.41026, 0.48428 };
            double[] answ_img = new double[5] { 0.03448, -0.00494, 0, 0.05128, -0.38553 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_b = new Complex(b_real[i], b_img[i]);
                Complex account_c = account_a / account_b;
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_Abs()
        {
            double[] answ = new double[5] { 3.16228, 10, 0, 22.36068, 0.49244 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                double account_c = Math.Round(account_a.Abs(), 5);
                Assert.AreEqual(account_c, answ[i]);
            }
        }

        [TestMethod]
        public void Test_Complex_Sqrt()
        {
            double[] answ_real = new double[5] { 1.44262, 2.23607, 0, 2.48603, 0.58841 };
            double[] answ_img = new double[5] { 1.03978, 2.23607, 0, 4.02248, 0.38239 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_c = account_a.Sqrt();
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_Pow()
        {
            double[] answ_real = new double[5] { 1, 0, 0, -70000, 0 };
            double[] answ_img = new double[5] { 0, 10, 0, -240000, 0 };
            int[] n = new int[5] { 0, 1, 3, 4, 100000 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                Complex account_c = account_a.Pow(n[i]);
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_Complex_ToPolar()
        {
            double[] answ_angle = new double[5] { 1.24905, 1.57080, 0, -2.03444, 1.15257 };
            double[] answ_rad = new double[5] { 3.16228, 10, 0, 22.36068, 0.49244 };

            for (int i = 0; i < 5; i++)
            {
                Complex account_a = new Complex(a_real[i], a_img[i]);
                PolarCoord account_c = account_a.ToPolar();
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }
    }

    [TestClass]
    public class UnitTest_PolarCoord
    {
        double[] a_rad = new double[5] { 3.16228, 10, 0, 22.36068, 0.49244 };
        double[] a_angle = new double[5] { 1.24905, 1.5708, 0, -2.03444, 1.15257 };

        double[] b_rad = new double[5] { 5.38516, 45.01111, 0, 54.08327, 0.79555 };
        double[] b_angle = new double[5] { 1.19029, 1.59301, 0, -2.1588, 1.82492 };

        [TestMethod]
        public void Test_PolarCoord_Plus()
        {
            double[] answ_rad = new double[5] { 8.544, 55.00909, 0, 76.32168, 1.22 };
            double[] answ_angle = new double[5] { 1.21203, 1.58897, 0, -2.12245, 1.5708 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_b = new PolarCoord(b_rad[i], b_angle[i]);
                PolarCoord account_c = account_a + account_b;
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Minus()
        {
            double[] answ_rad = new double[5] { 2.23606, 35.01428, 0, 32.01565, 0.51225 };
            double[] answ_angle = new double[5] { -2.03445, -1.54224, 0, 0.89605, -0.67475 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_b = new PolarCoord(b_rad[i], b_angle[i]);
                PolarCoord account_c = account_a - account_b;
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Multiply()
        {
            double[] answ_rad = new double[5] { 17.02939, 450.1111, 0, 1209.33866, 0.39176 };
            double[] answ_angle = new double[5] { 2.43934, -3.11937, 0, 2.08994, 2.97749 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_b = new PolarCoord(b_rad[i], b_angle[i]);
                PolarCoord account_c = account_a * account_b;
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Div()
        {
            double[] answ_rad = new double[5] { 0.58722, 0.22216, 0, 0.41345, 0.619 };
            double[] answ_angle = new double[5] { 0.05875, -0.02224, 0, 0.12435, -0.67235 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_b = new PolarCoord(b_rad[i], b_angle[i]);
                PolarCoord account_c = account_a / account_b;
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Abs()
        {
            double[] answ = new double[5] { 3.16228, 10, 0, 22.36068, 0.49244 };
            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                Assert.AreEqual(account_a.Abs(), answ[i]);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Sqrt()
        {
            double[] answ_rad = new double[5] { 1.77828, 3.16228, 0, 4.72871, 0.70175 };
            double[] answ_angle = new double[5] { 0.62452, 0.7854, 0, -1.01722, 0.57628 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_c = account_a.Sqrt();
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_Pow()
        {
            double[] answ_rad = new double[5] { 1, 10, 0, 250000.01006, 0 };
            double[] answ_angle = new double[5] { 0, 1.5708, 0, -1.85459, 0 };
            int[] n = new int[5] { 0, 1, 3, 4, 100000 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                PolarCoord account_c = account_a.Pow(n[i]);
                PolarCoord answer = new PolarCoord(answ_rad[i], answ_angle[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }

        [TestMethod]
        public void Test_PolarCoord_ToComplex()
        {
            double[] answ_real = new double[5] { 1, 0, 0, -10, 0.2 };
            double[] answ_img = new double[5] { 3, 10, 0, -20, 0.45 };

            for (int i = 0; i < 5; i++)
            {
                PolarCoord account_a = new PolarCoord(a_rad[i], a_angle[i]);
                Complex account_c = account_a.ToComplex();
                Complex answer = new Complex(answ_real[i], answ_img[i]);
                Assert.AreEqual(account_c == answer, true);
            }
        }
    }

}
