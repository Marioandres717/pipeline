using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;


namespace Sixeyed.Extensions.Test.Demo3
{
    [TestClass]
    public class ObjectExtensionsTest
    {
        [TestMethod]
        public void ToJsonStringTest()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.ToJsonString());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.ToJsonString());
        }

        [TestMethod]
        public void GetJsonTypeDescriptionTest()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.GetJsonTypeDescription());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.GetJsonTypeDescription());
        }
    }
}
