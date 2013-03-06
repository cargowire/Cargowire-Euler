using System;

using Cargowire.Euler.Common;

namespace Cargowire.Euler.Common
{
    public abstract class BaseProblemSolver<TProblem, TSolution> 
        : IProblemSolver<TProblem, TSolution> where TProblem : IEulerItem
    {
        protected TimeSpan _timeTaken;
        protected TSolution _solution = default(TSolution);
        protected string _workings = string.Empty;
        protected string _debugWorkings = string.Empty;

        public virtual TSolution Solution
        {
            get 
            {
                if (_solution.Equals(default(TSolution)))
                {
                    _solution = Calculate(out _timeTaken);
                }
                return _solution; 
            }
        }

        public virtual TSolution Calculate(out TimeSpan timeTaken) 
        {
            DateTime start = DateTime.Now;
            TSolution result = Calculate();
            timeTaken = DateTime.Now - start;
            return result;
        }

        public abstract TSolution Calculate();
        
        public virtual string ShowWorkings(bool debug)
        {
            return Solution.ToString(); // Solution is cached timed result
        }

        public virtual string ShowWorkings(bool debug, out TimeSpan timeTaken)
        {
            string result = ShowWorkings(debug); // Solution is cached timed result
            timeTaken = _timeTaken;
            return result;
        }
    }
}
