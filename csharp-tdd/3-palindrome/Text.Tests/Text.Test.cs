using System;
using Text;
using NUnit.Framework;

namespace Text.Tests
{
    /// <summary>Unit test</summary>
    [TestFixture]
    public class TextTests
    {
        [Test]
        public void isEmpty()
        {
            string s = "";

            bool res = Str.IsPalindrome(s);

            Assert.IsTrue(res);
        }

        [Test]
        public void strIsPalindrome()
        {
            string input = "A man, a plan, a canal: Panama.";

            bool result = Str.IsPalindrome(input);

            Assert.IsTrue(result);
        }

        [Test]
        public void strIsNotPalindrome()
        {
            string input = "This is not a palindrome";

            bool result = Str.IsPalindrome(input);

            Assert.IsFalse(result);
        }
    }
}
