using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Json5.Tests.Parsing
{
    [TestClass]
    public class BooleanTests
    {
        [TestMethod]
        public void TrueTest()
        {
            var v = Json5.Parse("true");
            Assert.IsTrue((bool)v);
        }

        [TestMethod]
        public void FalseTest()
        {
            var v = Json5.Parse("false");
            Assert.IsFalse((bool)v);
        }
    }
}
