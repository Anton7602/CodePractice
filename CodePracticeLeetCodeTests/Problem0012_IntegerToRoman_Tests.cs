using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeLeetCodeTests
{
    internal class Problem0012_IntegerToRoman_Tests
    {
        private Problem0012_IntegerToRoman problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem0012_IntegerToRoman();
        }

        [Test]
        public void TestCase1()
        {
            int num = 3;
            string output = "III";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            int num = 58;
            string output = "LVIII";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            int num = 1994;
            string output = "MCMXCIV";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            int num = 489;
            string output = "CDLXXXIX";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            int num = 894;
            string output = "DCCCXCIV";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }

        [Test]
        public void TestCase6()
        {
            int num = 512;
            string output = "DXII";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }


        [Test]
        public void TestCase7()
        {
            int num = 10;
            string output = "X";
            Assert.That(problem.Solve(num), Is.EqualTo(output));
        }
    }
}
