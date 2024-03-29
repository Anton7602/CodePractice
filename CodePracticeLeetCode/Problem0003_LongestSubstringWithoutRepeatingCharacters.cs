﻿namespace CodePracticeLeetCode
{
    // Given a string s, find the length of the longest substring without repeating characters.
    public class Problem0003_LongestSubstringWithoutRepeatingCharacters : IProblem
    {
        string? _s { get; set; }

        int _output { get; set; }

        public int LengthOfLongestSubstring(string s)
        {
            int counter = 0;
            int maxLenght = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);
                    counter++;
                    if (counter > maxLenght)
                    {
                        maxLenght = counter;
                    }
                }
                else
                {
                    counter = i - map[s[i]];
                    foreach (var item in map)
                    {
                        if (item.Value < map[s[i]])
                        {
                            map.Remove(item.Key);
                        }
                    }
                    map[s[i]] = i;
                }
            }
            return maxLenght;
        }

        public void ReadInput()
        {
            _s = ProblemIO.ReadStringFromConsole("Enter Input string (s)");
        }

        public void ShowAnswer()
        {
            ProblemIO.WriteValue(_output);
        }

        public void Solve()
        {
            _output = LengthOfLongestSubstring(_s);
        }
    }
}
