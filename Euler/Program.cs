using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Euler.Common;
using Euler.Problems;

namespace Euler
{
    public class Program
    {
        private static IDictionary<int, IEulerItem> _eulerProblems = new SortedDictionary<int, IEulerItem>();
        private static int _problemNumber;

        public static void Main(string[] args)
        {
            OutputHeader();
            PopulateProblemList();
            OutputInstructions();
            string cont = Console.ReadLine();
            while(int.TryParse(cont, out _problemNumber) || cont == "ls") {
                if (_problemNumber > 0)
                    OutputProblem(_problemNumber);
                else if(cont == "ls") {
                    _problemNumber = 0;
                    OutputAllProblems();
                }
                OutputInstructions();
                cont = Console.ReadLine();
            }
        }

        public static void OutputHeader()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("              Welcome to Euler problems");
            Console.WriteLine("=====================================================");
        }

        public static void OutputInstructions()
        {
            Console.WriteLine("Enter a problem number or type ls to enumerate all (anything else will exit):");
        }

        public static void PopulateProblemList()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            
            // Get all problems and add them to list
            foreach (Type type in asm.GetTypes())
            {
                if ((type.Namespace == "Euler.Problems")
                    && (type.GetInterface(typeof(IEulerItem).FullName) != null))
                {
                    try
                    {
                        _eulerProblems.Add(Convert.ToInt32(type.Name.Substring(7)), Activator.CreateInstance(type) as IEulerItem);
                    }catch(FormatException){}
                    catch (OverflowException){}
                }
            }
        }

        public static void OutputAllProblems()
        {
            int count = 0;
            foreach (IEulerItem problem in _eulerProblems.Values)
            {
                count++;
                OutputProblem(problem);
                if (count != _eulerProblems.Count) Console.ReadLine();
            }
        }
        public static void OutputProblem(int problemNumber)
        {
            OutputProblem(_eulerProblems[problemNumber]);
        }
        public static void OutputProblem(IEulerItem problem) {
            if (problem != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(string.Format("{0}:", problem.GetType().Name));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(problem.Problem);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Answer: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                TimeSpan timeTaken;
                Console.Write(string.Format("{0} [{1}] in {2} seconds", problem.ShowWorkings(false, out timeTaken), problem.ValidSolution() ? "Correct" : string.Format("Incorrect: {0}", problem.ConfirmedAnswer), timeTaken.TotalSeconds));
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
    }
}
