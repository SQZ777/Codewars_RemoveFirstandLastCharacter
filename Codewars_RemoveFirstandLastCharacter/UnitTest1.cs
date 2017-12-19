using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_RemoveFirstandLastCharacter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_OK()
        {
            Assert.AreEqual("ok",new Kata().Remove_char(string.Empty));
        }

        [TestMethod]
        public void Input_a_Should_Be_OK()
        {
            Assert.AreEqual("ok",new Kata().Remove_char("a"));
        }

        [TestMethod]
        public void Input_ab_Should_Be_StringEmpty()
        {
            Assert.AreEqual(string.Empty,new Kata().Remove_char("ab"));
        }

        [TestMethod]
        public void Input_AacABvbSdkPfbDk_Should_Be_acABvbSdkPfbD()
        {
            Assert.AreEqual("acABvbSdkPfbD", new Kata().Remove_char("AacABvbSdkPfbDk"));
        }

        [TestMethod]
        public void Input_ABC_Should_Be_B()
        {
            Assert.AreEqual("B", new Kata().Remove_char("ABC"));
        }

        [TestMethod]
        public void Input_SpecialChars_Should_BeCuttenString()
        {
            Assert.AreEqual("!@##$%^$%^", new Kata().Remove_char("B!@##$%^$%^A"));
        }
    }
}
