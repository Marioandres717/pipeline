using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

// Piggybacking namespaces (system)
// and overloading extension methods
namespace System
{
    public static class DateTimeExtensions
    {
        public static string ToXmlDateTime(this DateTime datetime, XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            return XmlConvert.ToString(datetime, mode);
        }
    }
}
