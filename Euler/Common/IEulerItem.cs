using System;

namespace Cargowire.Euler.Common
{
    public interface IEulerItem
    {
        object ConfirmedAnswer { get; }
        object Problem { get; }
        object Solution { get; }
        object Calculate();
        object Calculate(out TimeSpan timeTaken);
        string ShowWorkings(bool debug);
        string ShowWorkings(bool debug, out TimeSpan timeTaken);
        bool ValidSolution();
    }
}
