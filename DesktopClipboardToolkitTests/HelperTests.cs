using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopClipboardToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace DesktopClipboardToolkit.Tests
{
    [TestClass()]
    public class HelperTests
    {
        [TestMethod()]
        public void DoubleUpSingleQuotesTest()
        {
            
            var test = Helper.DoubleUpSingleQuotes("'");
            Assert.AreEqual("''", test);
        }

        [TestMethod()]
        public void CreateSQLINClauseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EmailTest()
        {
            Assert.Fail();
        }
    }
}