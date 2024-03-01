using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeLeetCodeTests
{
    internal class Problem3_LongestSubstringWithoutRepeatingCharacters_Tests
    {
        private Problem3_LongestSubstringWithoutRepeatingCharacters problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem3_LongestSubstringWithoutRepeatingCharacters();
        }

        [Test]
        public void TestCase1()
        {
            string s = "abcabcbb";
            int output = 3;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "bbbbb";
            int output = 1;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "pwwkew";
            int output = 3;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "aab";
            int output = 2;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string s = "dvdf";
            int output = 3;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            string s = "tmmzuxt";
            int output = 5;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void EndgeCaseMin_TestCase()
        {
            string s = "";
            int output = 0;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }

        [Test]
        public void EndgeCaseMax_TestCase()
        {
            string s = "";
            for (int i = 0; i < (5 * 10000); i++)
            {
                s += "a";
            }
            int output = 1;
            Assert.That(problem.Solve(s), Is.EqualTo(output));
        }


    }
}
