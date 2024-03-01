using CodePracticeLeetCode;

namespace CodePractice
{
    internal class Program
    {
        static IProblem problem = new Problem2_AddTwoNumbers();

        static void Main(string[] args)
        {
            problem.ReadInput();
            problem.Solve();
            problem.ShowAnswer();
        }
    }
}
