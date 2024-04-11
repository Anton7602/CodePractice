namespace CodePracticeLeetCode
{
    public class Problem0038_CountAndSay : IProblem
    {
        private int _n { get; set; }
        private string _output { get; set; }

        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            return Say(Count(n));
        }

        public List<(byte, byte)> Count(int n)
        {
            if (n == 2) return new List<(byte, byte)>() { (1, 1) };
            List<(byte, byte)> previousCount = Count(n - 1);
            List<(byte, byte)> currentCount = new List<(byte, byte)>();
            (byte, byte) lastPair = (previousCount[0].Item1, 0);
            foreach (var item in previousCount)
            {
                if (item.Item1 == lastPair.Item1) lastPair.Item2++;
                else
                {
                    currentCount.Add(lastPair);
                    lastPair = (item.Item1, 1);
                }
                if (item.Item2 == lastPair.Item1) lastPair.Item2++;
                else
                {
                    currentCount.Add(lastPair);
                    lastPair = (item.Item2, 1);
                }
            }
            currentCount.Add(lastPair);
            return currentCount;
        }

        private string Say(List<(byte, byte)> count)
        {
            string say = "";
            foreach (var item in count)
            {
                say = item.Item2.ToString() + item.Item1.ToString() + say;
            }
            return say;
        }

        public void ReadInput()
        {
            _n = ProblemIO.ReadIntFromConsole("Enter number of required element of CountAndSay sequence (n):");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = CountAndSay(_n);
        }
    }
}
