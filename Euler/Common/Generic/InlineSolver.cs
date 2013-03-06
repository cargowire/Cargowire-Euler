using System;

namespace Cargowire.Euler.Common
{
    public class InlineSolver<TProblem, TSolution> : BaseProblemSolver<TProblem, TSolution> where TProblem : IEulerItem
    {
        protected Func<TSolution> _solver;
        public InlineSolver(Func<TSolution> solver)
        {
            _solver = solver;
        }

        public override TSolution Calculate()
        {
            return _solver();
        }
    }
}
