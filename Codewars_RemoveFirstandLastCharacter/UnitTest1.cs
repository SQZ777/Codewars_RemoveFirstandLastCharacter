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

    }
}
