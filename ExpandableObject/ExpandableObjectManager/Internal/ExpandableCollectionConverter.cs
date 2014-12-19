using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace ExpandableObjectManager.Internal
{
    internal class ExpandableCollectionConverter : ExpandableObjectConverter
    {
        public override PropertyDescriptorCollection GetProperties(
            ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            Debug.Assert(value != null, "Value should not be null in this context.");

            var propDescriptors = GetPropertyDescriptors((IList)value);

            return new PropertyDescriptorCollection(propDescriptors);
        }

        private static PropertyDescriptor[] GetPropertyDescriptors(IList list)
        {
            int count = list.Count;
            var properties = new PropertyDescriptor[count];

            for (int index = 0; index < count; index++)
            {
                properties[index] = new CollectionItemPropertyDescriptor(list, index);
            }

            return properties;
        }
    }
}