using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValidInput()
        {
            Assert.IsTrue(Program.TryParseArguments(new[] { "a", "b" }, out var functionality, out var fileName));
            Assert.AreEqual("a", functionality);
            Assert.AreEqual("b", fileName);
        }

        [TestMethod]
        public void InvalidInput()
        {
            Assert.IsFalse(Program.TryParseArguments(null, out var _, out var __));
            Assert.IsFalse(Program.TryParseArguments(new string[] { }, out _, out __));
            Assert.IsFalse(Program.TryParseArguments(new[] { "a" }, out _, out __));
            Assert.IsFalse(Program.TryParseArguments(new[] { "a", "b", "c" }, out _, out __));
        }
    }
}
