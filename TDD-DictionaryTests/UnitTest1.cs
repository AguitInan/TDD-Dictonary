using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDD_DictionaryCore;

namespace TDD_DictionaryTests
{
    [TestClass]
    public class StringReplacerTests
    {
        [TestMethod]
        public void ReplaceString_WithEmptyStringAndEmptyDict_ReturnsEmptyString()
        {
            var dict = new Dictionary<string, string>();
            string input = "";
            string result = StringReplacer.ReplaceString(input, dict);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ReplaceString_WithOneReplacement_ReturnsReplacedString()
        {
            var dict = new Dictionary<string, string> { { "temp", "temporaire" } };
            string input = "$temp$";
            string result = StringReplacer.ReplaceString(input, dict);
            Assert.AreEqual("temporaire", result);
        }

        [TestMethod]
        public void ReplaceString_WithMultipleReplacements_ReturnsReplacedString()
        {
            var dict = new Dictionary<string, string>
            {
                { "temp", "temporary" },
                { "name", "John Doe" }
            };
            string input = "$temp$ here comes the name $name$";
            string result = StringReplacer.ReplaceString(input, dict);
            Assert.AreEqual("temporary here comes the name John Doe", result);
        }
    }
}
