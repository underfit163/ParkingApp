using System;
using System.Collections.Generic;

namespace ParkingApp.Classes.ModelingClasses
{
    class DistributionsClass
    {
        Random random;
        public List<double> generateUniformValues(double a, double b)
        {
            random = new Random();
            List<double> uniformValues = new List<double>();
            double r_i;
            double result_i;

            while (uniformValues.Count != 100)
            {
                r_i = random.NextDouble();
                result_i = a + (b - a) * r_i;
                result_i = (Math.Round(result_i, 1));
                if (result_i != 0)
                {
                    uniformValues.Add(result_i);
                }
            }
            return uniformValues;
        }

        public List<double> generateExponentialValues(double lambda)
        {
            random = new Random();
            List<double> exponentialValues = new List<double>();

            double r_i, x_i;
            while (exponentialValues.Count != 100)
            {
                r_i = random.NextDouble();
                x_i = (-1 / lambda) * Math.Log(r_i);
                x_i = (Math.Round(x_i, 1));
                if (x_i != 0)
                {
                    exponentialValues.Add(x_i);
                }
            }
            return exponentialValues;
        }

        public List<double> generateNormalValues(double MX, double DX)
        {
            random = new Random();
            List<double> normalValues = new List<double>();
            double dSumm, dRandValue, R;
            Random ran = new Random();
            while (normalValues.Count != 100)
            {
                dSumm = 0;
                for (int i = 0; i <= 12; i++)
                {
                    R = ran.NextDouble();
                    dSumm = dSumm + R;
                }
                dRandValue = Math.Round((MX + DX * (dSumm - 6)), 1);
                if (dRandValue != 0)
                {
                    normalValues.Add(Math.Abs(dRandValue));
                }
            }
            return normalValues;
        }
    }
}