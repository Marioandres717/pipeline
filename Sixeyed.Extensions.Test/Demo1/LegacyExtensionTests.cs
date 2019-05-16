using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sixeyed.Extensions.Samples.Demo1;

namespace Sixeyed.Extensions.Test
{
    [TestClass]
    public class LegacyExtensionTests
    {
        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Mario Andres";
            Assert.AreEqual("ANDRES, MARIO", name.ToLegacyFormat());
        }
    }
}