using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassDemochoServer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemochoServer.Tests
{
    [TestClass()]
    public class ServerTests
    {
        [TestMethod()]
        public void Test1()
        {
            String line = "";
            string returnLine = ClassDemochoServer.Server.HandleClient(line);

            Assert.AreEqual("", returnLine);

        }

        [TestMethod()]
        public void Test2()
        {
            String line = null;
            string returnLine = ClassDemochoServer.Server.HandleClient(line);

            Assert.IsNull(returnLine);
        }

        [TestMethod()]
        public void Test3()
        {
            String line = "Peter";
            string returnLine = ClassDemochoServer.Server.HandleClient(line);

            Assert.AreEqual("Peter", returnLine);
        }


    }
}