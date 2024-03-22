namespace CodePracticeLeetCode
{
    //Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    public class Problem0022_GenerateParentheses : IProblem
    {
        private int _n {  get; set; }
        private IList<string>? _output {  get; set; }

        public IList<string> GenerateParenthesis(int n)
        {
            List<string> combinationsList = new List<string>();
            AddNextBraket(combinationsList, "(", n - 1, 1);
            return combinationsList.ToArray();
        }

        public void AddNextBraket(List<string> combinationList,string incomingString, int openBrakets, int closedBrakets)
        {
            if (openBrakets==0)
            {
                for(int i=0; i<closedBrakets; i++)
                {
                    incomingString+=')';
                }
                combinationList.Add(incomingString);
                return;
            } else
            {
                AddNextBraket(combinationList, incomingString+'(', openBrakets-1, closedBrakets+1);
            }
            if (closedBrakets!=0)
            {
                AddNextBraket(combinationList, incomingString + ')', openBrakets, closedBrakets-1);
            }
        }

        public void ReadInput()
        {
            _n = ProblemIO.ReadIntFromConsole("Input number of pairs of parenthesis (n):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer:");
            int index = 1;
            foreach(string combination in _output)
            {
                Console.WriteLine($"Combination {index}: {combination}");
                index++;
            }
        }

        public void Solve()
        {
            _output = GenerateParenthesis(_n);
        }
    }
}
