using Microsoft.VisualStudio.TestTools.UnitTesting;
using OFXParser.Entities;

namespace OFXParser.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Extract extraxt = OFXParser.Parser.GetExtract("check.ofx", new ParserSettings());
        }
    }
}
