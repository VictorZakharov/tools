using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using ExpandableObjectManager.Internal;

namespace ExpandableObjectManager
{
    public static class TypeDescriptors
    {
        #region "Public methods"

        public static void Add(Type tItem)
        {
            Type tConverter = GetConverterForType(tItem);
            TypeDescriptor.AddAttributes(tItem, new TypeConverterAttribute(tConverter));
        }

        public static void Add()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Add(assembly);
        }

        public static void Add(Assembly assembly)
        {
            Add(assembly, null);
        }

        public static void Add(Assembly assembly, string filter)
        {
            foreach (Type tpCurrent in assembly.GetTypes())
            {
                string sNamespace = tpCurrent.Namespace;

                if (IncludeType(sNamespace, filter))
                {
                    Add(tpCurrent);
                }
            }
        }

        #endregion

        #region "Private methods"

        private static bool IncludeType(string sNamespace, string filter)
        {
            if (sNamespace == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(filter))
            {
                return true;
            }

            return sNamespace.StartsWith(filter);
        }

        private static Type GetConverterForType(Type tItem)
        {
            if (tItem.ImplementsInterface(typeof(IList)))
            {
                return typeof(ExpandableCollectionConverter);
            }
            else
            {
                return typeof(ExpandableObjectConverter);
            }
        }

        #endregion
    }
}