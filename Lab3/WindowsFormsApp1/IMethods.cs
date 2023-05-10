using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericMethodsLab1 { 
    public interface IMethods
    {
        double Function(double x);

        double Function_Der(double x);
        double Function_Der2(double x);
        double FiFunc(double x);
        double FiFuncDer(double x);

        double Dichotomy(double a, double b);

        double MNewtonMethod(double a, double b);

        double SimpleIteration(double a, double b, double x0);

        bool CheckFI(double a, double b, double x0, double q);

        int AprioriSI(double b, double x0);

        int APrioriDichotomy(double a, double b);

    }
}
    

