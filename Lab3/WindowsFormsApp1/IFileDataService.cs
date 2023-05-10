using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericMethodsLab1
{
    public interface IFileDataService
    {
        (double, double) ReadData();
    }
}
