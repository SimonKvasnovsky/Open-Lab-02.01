using System;
using System.Security.Authentication.ExtendedProtection;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] pole = new double[5];
            pole[0] = 10;
            pole[1] = 125;
            pole[2] = 11;
            pole[3] = 17;
            pole[4] = 81;
            return pole;
        }

        public double GetSecond(double[] numbers) 
        {
            return numbers[1];
        }
    }
}