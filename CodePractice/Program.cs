using CodePracticeLeetCode;

namespace CodePractice
{
    internal class Program
    {
        static IProblem problem = new Problem0018_4Sum();

        static void Main(string[] args)
        {
            problem.ReadInput();
            problem.Solve();
            problem.ShowAnswer();
        }
    }
}
