using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Common
{
    public interface IEulerItem<P,S>
    {
        S ConfirmedAnswer { get; }
        P Problem { get; }
        S Solution { get; }
        S Calculate();
        S Calculate(out TimeSpan timeTaken);
        string ShowWorkings(bool debug);
        string ShowWorkings(bool debug, out TimeSpan timeTaken);
        bool ValidSolution();
    }
}
