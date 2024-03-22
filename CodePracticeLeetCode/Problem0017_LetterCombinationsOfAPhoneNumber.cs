namespace CodePracticeLeetCode
{
    /*
     * Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
     * A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
     */
    public class Problem0017_LetterCombinationsOfAPhoneNumber : IProblem
    {
        private string _digits {  get; set; }
        private IList<string> _output {  get; set; } = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, List<char>> digitToLetterMap = new Dictionary<char, List<char>>();
            digitToLetterMap.Add('2', new List<char>() { 'a', 'b', 'c' });
            digitToLetterMap.Add('3', new List<char>() { 'd', 'e', 'f' });
            digitToLetterMap.Add('4', new List<char>() { 'g', 'h', 'i' });
            digitToLetterMap.Add('5', new List<char>() { 'j', 'k', 'l' });
            digitToLetterMap.Add('6', new List<char>() { 'm', 'n', 'o' });
            digitToLetterMap.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
            digitToLetterMap.Add('8', new List<char>() { 't', 'u', 'v' });
            digitToLetterMap.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });
            List<string> letterCombinations = new List<string>() { "" };
            foreach(char digit in digits)
            {
                if (digitToLetterMap.ContainsKey(digit)) {
                    List<string> appendedCombinations = new List<string>();
                    foreach(string combination in letterCombinations)
                    {
                        foreach (char letter in digitToLetterMap[digit])
                        {
                            appendedCombinations.Add(combination + letter);
                        }
                    }
                    letterCombinations = appendedCombinations;
                }
            }
            if (letterCombinations.Count == 1) letterCombinations.Clear();
            return letterCombinations;
        }

        public void ReadInput()
        {
            _digits = ProblemIO.ReadStringFromConsole("Enter string with number (digits):");
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Answer");
            foreach(string value in _output)
            {
                Console.Write(value + ", ");
            }
        }

        public void Solve()
        {
            _output = LetterCombinations(_digits);
        }
    }
}
