using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Sixeyed.Extensions.Samples.Adv_Demo1
{
    public static class InstrumentationExtensions
    {
        // simulating state in static collection (work around private member fields)
        // The drawbacks of using static members of an extension are:
        // 1) There is no Garbage collection for the elements in the dictionary, Therefore not suitable for large number of elements.
        private static Dictionary<Guid, Stopwatch> _Stopwatches = new Dictionary<Guid, Stopwatch>();
        public static double GetPreciseElapsedTime(this Instrumentation instrumentation)
        {
            // using reflection to access private member of class at run time
            // The drawbacks of reflection are:
            // 1) It has a performance penalty cost
            // 2) Reflection breaks if type changes
            var fieldInfo = typeof(Instrumentation).GetField("_startedAt", BindingFlags.Instance | BindingFlags.NonPublic);
            var startedAt = (DateTime)fieldInfo.GetValue(instrumentation);
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }

        public static void StartWithPrecision(this Instrumentation instrumentation)
        {
            _Stopwatches[instrumentation.Id] = Stopwatch.StartNew();
        }

        public static long getReallyPreciseElapsedTime(this Instrumentation instrumentation)
        {
            return _Stopwatches[instrumentation.Id].ElapsedMilliseconds;
        }
    }
}
