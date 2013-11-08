using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetThePageRank.DLL;

namespace GetThePageRank.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDomainsAndMail()
        {
           int hotURL= GooglePR.MyPageRank("hotmail.com");
           int hotMail = GooglePR.MyPageRankFromMail("nico_sap@hotmail.com");

           Assert.AreNotEqual(hotURL, -1); //site definatly exists
           Assert.AreEqual(hotURL, hotMail,"different pagerank for hotmailaddresses");
        }

    }
}
