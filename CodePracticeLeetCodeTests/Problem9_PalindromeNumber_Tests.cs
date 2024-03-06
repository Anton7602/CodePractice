using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeLeetCodeTests
{
    internal class Problem9_PalindromeNumber_Tests
    {
        private Problem9_PalindromeNumber problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem9_PalindromeNumber();
        }

        [Test]
        public void TestCase1()
        {
            int x = 121;
            bool output = true;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int x = -121;
            bool output = false;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int x = 10;
            bool output = false;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int x = 9;
            bool output = true;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int x = -9;
            bool output = false;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int x = Int32.MaxValue;
            bool output = false;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase7()
        {
            int x = 123454321;
            bool output = true;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase8()
        {
            int x = 0;
            bool output = true;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }

        [Test]
        public void TestCase9()
        {
            int x = 951464159;
            bool output = true;
            Assert.That(problem.Solve(x), Is.EqualTo(output));
        }
    }
}
