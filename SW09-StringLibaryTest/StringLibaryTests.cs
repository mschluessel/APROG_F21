using Microsoft.VisualStudio.TestTools.UnitTesting;
using SW09_StringLibary;

namespace SW09_StringLibaryTest {

    [TestClass]
    public class StringLibaryTests {

        //[TestMethod]
        //public void TestMethod1() {
        //    Assert.IsTrue(true);
        //    Assert.IsFalse(true);
        //}

        [TestMethod]
        public void StartsWithUpperTests() {
            Assert.IsTrue(SW09_StringLibary.StringLibary.StartsWithUpper("String"));
        }

        [TestMethod]
        public void StartsWithLowerTests() {
            Assert.IsTrue(SW09_StringLibary.StringLibary.StartsWithLower("String"));
        }

        [TestMethod]
        public void HasEmbeddedSpacesTests() {
            Assert.IsTrue(SW09_StringLibary.StringLibary.StartsWithUpper("öppis"));
        }
    }
}
