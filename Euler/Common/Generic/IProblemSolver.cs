using System;

namespace Cargowire.Euler.Common
{
    /// <typeparam name="TProblem">The problem this is a solver for e.g. Problem1</typeparam>
    /// <typeparam name="TSolution">The solution type e.g. int, float</typeparam>
    public interface IProblemSolver<out TProblem, TSolution> where TProblem : IEulerItem
    {
        TSolution Solution { get; }

        TSolution Calculate();
        TSolution Calculate(out TimeSpan timeTaken);

        string ShowWorkings(bool debug);
        string ShowWorkings(bool debug, out TimeSpan timeTaken);
    }
}
