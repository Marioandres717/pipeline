using System;
using System.Collections.Generic;
using System.Text;

namespace Sixeyed.Extensions.Samples.Demo3
{
    public static class TypeExtensions
    {
        public static TypeDescription GetDescription(this Type type)
        {
            return new TypeDescription
            {
                AssemblyQualifiedName = type.AssemblyQualifiedName,
                FullName = type.FullName
            };
        }
    }

    public class TypeDescription
    {
        public string FullName { get; set; }
        public string AssemblyQualifiedName { get; set; }
    }
}
