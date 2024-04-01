namespace CodePracticeLeetCodeTests
{
    internal class Problem0030_SubstringWithConcatenationOfAllWords_Tests
    {
        private Problem0030_SubstringWithConcatenationOfAllWords problem;
        [SetUp]
        public void Setup()
        {
            problem = new Problem0030_SubstringWithConcatenationOfAllWords();
        }

        [Test]
        public void TestCase1()
        {
            string s = "barfoothefoobarman";
            string[] words = { "foo", "bar" };
            List<int> output = new List<int> { 0, 9 };
            Assert.That(problem.FindSubstring(s, words), Is.EqualTo(output));
        }

        [Test]
        public void TestCase2()
        {
            string s = "wordgoodgoodgoodbestword";
            string[] words = { "word", "good", "best", "word" };
            List<int> output = new List<int>();
            Assert.That(problem.FindSubstring(s, words), Is.EqualTo(output));
        }

        [Test]
        public void TestCase3()
        {
            string s = "barfoofoobarthefoobarman";
            string[] words = { "bar", "foo", "the" };
            List<int> output = new List<int> { 6, 9, 12 };
            Assert.That(problem.FindSubstring(s, words), Is.EqualTo(output));
        }

        [Test]
        public void TestCase4()
        {
            string s = "wordgoodgoodgoodbestword";
            string[] words = { "word", "good", "best", "good" };
            List<int> output = new List<int> { 8 };
            Assert.That(problem.FindSubstring(s, words), Is.EqualTo(output));
        }

        [Test]
        public void TestCase5()
        {
            string s = "pjzkrkevzztxductzzxmxsvwjkxpvukmfjywwetvfnujhweiybwvvsrfequzkhossmootkmyxgjgfordrpapjuunmqnxxdrqrfgkrsjqbszgiqlcfnrpjlcwdrvbumtotzylshdvccdmsqoadfrpsvnwpizlwszrtyclhgilklydbmfhuywotjmktnwrfvizvnmfvvqfiokkdprznnnjycttprkxpuykhmpchiksyucbmtabiqkisgbhxngmhezrrqvayfsxauampdpxtafniiwfvdufhtwajrbkxtjzqjnfocdhekumttuqwovfjrgulhekcpjszyynadxhnttgmnxkduqmmyhzfnjhducesctufqbumxbamalqudeibljgbspeotkgvddcwgxidaiqcvgwykhbysjzlzfbupkqunuqtraxrlptivshhbihtsigtpipguhbhctcvubnhqipncyxfjebdnjyetnlnvmuxhzsdahkrscewabejifmxombiamxvauuitoltyymsarqcuuoezcbqpdaprxmsrickwpgwpsoplhugbikbkotzrtqkscekkgwjycfnvwfgdzogjzjvpcvixnsqsxacfwndzvrwrycwxrcismdhqapoojegggkocyrdtkzmiekhxoppctytvphjynrhtcvxcobxbcjjivtfjiwmduhzjokkbctweqtigwfhzorjlkpuuliaipbtfldinyetoybvugevwvhhhweejogrghllsouipabfafcxnhukcbtmxzshoyyufjhzadhrelweszbfgwpkzlwxkogyogutscvuhcllphshivnoteztpxsaoaacgxyaztuixhunrowzljqfqrahosheukhahhbiaxqzfmmwcjxountkevsvpbzjnilwpoermxrtlfroqoclexxisrdhvfsindffslyekrzwzqkpeocilatftymodgztjgybtyheqgcpwogdcjlnlesefgvimwbxcbzvaibspdjnrpqtyeilkcspknyylbwndvkffmzuriilxagyerjptbgeqgebiaqnvdubrtxibhvakcyotkfonmseszhczapxdlauexehhaireihxsplgdgmxfvaevrbadbwjbdrkfbbjjkgcztkcbwagtcnrtqryuqixtzhaakjlurnumzyovawrcjiwabuwretmdamfkxrgqgcdgbrdbnugzecbgyxxdqmisaqcyjkqrntxqmdrczxbebemcblftxplafnyoxqimkhcykwamvdsxjezkpgdpvopddptdfbprjustquhlazkjfluxrzopqdstulybnqvyknrchbphcarknnhhovweaqawdyxsqsqahkepluypwrzjegqtdoxfgzdkydeoxvrfhxusrujnmjzqrrlxglcmkiykldbiasnhrjbjekystzilrwkzhontwmehrfsrzfaqrbbxncphbzuuxeteshyrveamjsfiaharkcqxefghgceeixkdgkuboupxnwhnfigpkwnqdvzlydpidcljmflbccarbiegsmweklwngvygbqpescpeichmfidgsjmkvkofvkuehsmkkbocgejoiqcnafvuokelwuqsgkyoekaroptuvekfvmtxtqshcwsztkrzwrpabqrrhnlerxjojemcxel";
            string[] words = { "dhvf", "sind", "ffsl", "yekr", "zwzq", "kpeo", "cila", "tfty", "modg", "ztjg", "ybty", "heqg", "cpwo", "gdcj", "lnle", "sefg", "vimw", "bxcb" };
            List<int> output = new List<int> { 935 };
            Assert.That(problem.FindSubstring(s, words), Is.EqualTo(output));
        }
    }
}
