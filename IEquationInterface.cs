using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    public interface IEquationInterface
    {
        List<double> Solve(double a, double b, double c);
    }
}
