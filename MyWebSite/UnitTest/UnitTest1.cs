using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebSite.App_Code;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStringReverse()
        {
            StringReverse oStringReverse = new StringReverse();
            string name = "Chang";
            string reverseName;
            reverseName = oStringReverse.Process(name);
            Assert.IsTrue(reverseName.ToLower() == "gnahc");
        }
    }
}
