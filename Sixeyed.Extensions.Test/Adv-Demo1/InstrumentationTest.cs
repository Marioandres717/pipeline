using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Adv_Demo1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sixeyed.Extensions.Test.Adv_Demo1
{
    [TestClass]
    public class InstrumentationTest
    {
        [TestMethod]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());
        }

        // using implementation with reflection
        [TestMethod]
        public void GetPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetElapsedTime();
            Assert.IsTrue(elapsed >= 0.75 && elapsed <= 1);
        }

        // using implementation with InstrumentationExtention static dictionary field
        [TestMethod]
        public void GetReallyPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();

            Thread.Sleep(750);
            Assert.AreEqual(750, instrumentation.getReallyPreciseElapsedTime());
        }
    }
}
