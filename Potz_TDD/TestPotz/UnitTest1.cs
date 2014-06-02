using Microsoft.VisualStudio.TestTools.UnitTesting;
using Potz_TDD;

namespace TestPotz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsValidoTestTrue()
        {
            CupomPotz cupompotz = new CupomPotz("500036532-7");
            Assert.IsTrue(cupompotz.isValido());
        }

        [TestMethod]
        public void IsValidoTestFalse()
        {
            CupomPotz cupompotz = new CupomPotz("100036532-7");

            Assert.IsFalse(cupompotz.isValido());
        }
    }
}
