using System;
using System.Reflection;

namespace Org.BouncyCastle
{
    internal static class PortableHelpers
    {
        internal static bool IsInstanceOfType(this Type type, object obj)
        {
            return obj != null && type.GetTypeInfo().IsAssignableFrom(obj.GetType().GetTypeInfo());
        }
    }
}