using NUnit.Framework;

namespace Unidecode.AspNetCore.Tests
{
    [TestFixture]
    public class Unicoder
    {
        [Test]
        public void UnidecodeTest()
        {
            Assert.AreEqual("Bei Jing ", "\u5317\u4EB0".Unidecode());
            Assert.AreEqual("Rabota s kirillitsey", "Работа с кириллицей".Unidecode());
            Assert.AreEqual("Hello, World!", "Hello, World!".Unidecode());
            Assert.AreEqual("'\"\r\n", "'\"\r\n".Unidecode());
            Assert.AreEqual("CZSczs", "ČŽŠčžš".Unidecode());
            Assert.AreEqual("a", "ア".Unidecode());
            Assert.AreEqual("a", "α".Unidecode());
            Assert.AreEqual("a", "а".Unidecode());
            Assert.AreEqual("chateau", "ch\u00e2teau".Unidecode());
            Assert.AreEqual("vinedos", "vi\u00f1edos".Unidecode());
        }
    }
}
