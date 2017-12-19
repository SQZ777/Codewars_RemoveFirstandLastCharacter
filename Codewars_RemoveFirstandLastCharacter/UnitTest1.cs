using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_RemoveFirstandLastCharacter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_OK()
        {
            //arrange
            var input = string.Empty;
            var kata = new Kata();
            //actual
            var removedResult = kata.Remove_char(input);
            //assert
            Assert.AreEqual("ok",removedResult);
        }

        [TestMethod]
        public void Input_()
        {

        }
    }
}
