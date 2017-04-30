using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaceBookSlotsApp;

namespace UnitTestProject1
{
    [TestClass]
    public class ParserTests
    {
        Parser parser;

        [TestInitialize]
        public void Initialize()
        {
            parser = new Parser();
        }
        [TestMethod]
        public void MakesNewLines()
        {
            var testString = "guy ferra\nloius throaty";
            var result = parser.Parse(testString);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void StripsEmptyLines()
        {
            var testString = "guy ferra\nloius throaty\n\n\n";
            var result = parser.Parse(testString);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void StripsAddFriend()
        {
            var testString = "guy ferra\nAdd Friend\nloius throaty\nAdd Friend\n\n";
            var result = parser.Parse(testString);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void StripsFriendsInCommon()
        {
            var testString = "guy ferra\n2 mutual friends\n\n1 mutual Friend\nAdd Friend\nloius throaty\nAdd Friend\n\n";
            var result = parser.Parse(testString);

            Assert.AreEqual(2, result.Count);
        }
    }
}
