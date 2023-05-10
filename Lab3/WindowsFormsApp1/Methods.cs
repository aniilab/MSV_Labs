using System;
using System.Collections.Generic;

namespace NumericMethodsLab1
{
    public class Methods : IMethods
    {
        public double epsilon = 10e-5;
        public int Apost1 = 0, Apost2 = 0, Apost3 = 0;
        public double qSI = 0;

        private IFileDataService _fileDataService;
        public Methods() 
        {
            _fileDataService = new FileDataService();
        }

        public Methods(IFileDataService fileDataService) 
        {
            _fileDataService = fileDataService;
        }


        public (double, double) GetGap()
        {
            double a = _fileDataService.ReadData().Item1;
            double b = _fileDataService.ReadData().Item2;
            return (a, b);
        }

        public double Function(double x)
        {
            return (Math.Pow(x, 3) + 4 * Math.Sin(x)); ;
        }
        public double Function_Der(double x)
        {
            return (3 * Math.Pow(x, 2) + 4 * Math.Cos(x));
        }
        public double Function_Der2(double x)
        {
            return (6 * x - 4 * Math.Sin(x));
        }
        public  double FiFunc(double x)
        {
            double a = -0.25 * Math.Pow(x, 3);
            double fi = Math.Asin(a);
            return fi;
        }
        public  double FiFuncDer(double x)
        {
            double fi_der = -3 * Math.Pow(x, 2) * (1 / Math.Sqrt(16 - Math.Pow(x, 6)));
            return fi_der;
        }

        public  double Dichotomy(double a, double b)
        { 
            double xn = 0;
            while (Math.Abs(b - a) > epsilon)
            {
                xn = (a + b) / 2;
                if (Function(xn) * Function(a) > 0)
                {
                    a = xn;
                }
                else
                {
                    b = xn;
                }
                Apost1++;
                if (Function((a + b) / 2) == 0) break;
            }
            return ((a + b) / 2);
        }

        public  double MNewtonMethod(double a, double b)
        {
            double x, x0;
            if (Function(a) * Function_Der2(a) > 0) x0 = a;
            else x0 = b;
            x = x0;
            double funcDer = Function_Der(x0);
            do
            {
                x0 = x;
                x = x0 - (Function(x0) / funcDer);
                Apost2++;
            } while (Math.Abs(x - x0) > epsilon);
            return x;
        }

        public  double SimpleIteration(double a, double b, double x0)
        {
            double lim, x = x0;
            double q = Math.Abs(FiFuncDer(b));
            qSI = q;
            if (!CheckFI(a, b, x0, q))
            {
                throw new ArgumentException("Wrong fi function!");
            }

            if (q < 0.5)
            {
                lim = ((1 - q) * epsilon) / q;
            }
            else lim = epsilon;

            do
            {
                x0 = x;
                x = FiFunc(x);
                Apost3++;
            } while ((Math.Abs(x - x0)) > lim);
            return x;
        }

        public  bool CheckFI(double a, double b, double x0, double q)
        {
            if (q >= 1) return false;
            double delta = Math.Max(Math.Abs(a - x0), Math.Abs(b - x0));
            double lim = (1 - q) * delta;
            if (Math.Abs(FiFunc(x0) - x0) >= lim)
            {
                return false;
            }
            else return true;
        }

        public  int AprioriSI(double b, double x0)
        {
            double q = Math.Abs(FiFuncDer(b));
            int apriori = (int)((Math.Log(Math.Abs(FiFunc(x0) - x0) / ((1 - q) * epsilon))) / Math.Log(1 / q)) + 1;
            return apriori;
        }

        public  int APrioriDichotomy(double a, double b)
        {
            return (int)(Math.Log((b - a) / epsilon) / Math.Log(2)) + 1;
        }

        public  List<double> AllRoots(double a, double b, double x0)
        {
            List<double> roots = new List<double>();
            roots.Add(Dichotomy(a,b));
            roots.Add(MNewtonMethod(a, b));
            roots.Add(SimpleIteration(a,b,x0)); 
            return roots;
        }

        public  string KindsOfFunction(double x)
        {
            string result = "F(x) = " + Function(x);
            result +="\nF'(x) = "+ Function_Der(x);
            result += "\nF''(x) = " + Function_Der2(x);
            return result;
        }

    }
}
