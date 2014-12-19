using System;
using System.Linq;

namespace ExpandableObjectManager.Internal
{
    internal static class TypeExtensions
    {
        public static bool ImplementsInterface(this Type t, Type interfaceType)
        {
            return t.GetInterfaces().Contains(interfaceType);
        }
    }
}
