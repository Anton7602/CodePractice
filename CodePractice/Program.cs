using CodePracticeLeetCode;

namespace CodePractice
{
    internal class Program
    {
        static IProblem problem = new Problem0028_FindTheIndexOfTheFirstOccurrenceInAString();

        static void Main(string[] args)
        {
            problem.ReadInput();
            problem.Solve();
            problem.ShowAnswer();
        }
    }
}
