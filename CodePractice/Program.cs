using CodePracticeLeetCode;

namespace CodePractice
{
    internal class Program
    {
        static IProblem problem = new Problem0016_3SumClosest();

        static void Main(string[] args)
        {
            problem.ReadInput();
            problem.Solve();
            problem.ShowAnswer();
        }
    }
}
