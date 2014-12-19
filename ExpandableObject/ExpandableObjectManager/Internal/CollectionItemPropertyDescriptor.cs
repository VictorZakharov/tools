using System;
using System.Collections;
using System.ComponentModel;

namespace ExpandableObjectManager.Internal
{
    internal class CollectionItemPropertyDescriptor : PropertyDescriptor
    {
        private readonly int _iIndex;
        
        private readonly Type _tItem;
        private readonly Type _tCollection;

        public CollectionItemPropertyDescriptor(IList list, int index)
            : base(GetIndexFormatted(index, list.Count), null)
        {
            _tCollection = list.GetType();
            _tItem = list[index].GetType();

            _iIndex = index;
        }

        private static string GetIndexFormatted(int index, int count)
        {
            string sIndexFormatted = index.ToString().PadLeft(count.ToString().Length, '0');
            return "Item" + sIndexFormatted;
        }

        public override Type PropertyType
        {
            get { return _tItem; }
        }

        public override Type ComponentType
        {
            get { return _tCollection; }
        }

        public override object GetValue(object component)
        {
            IList list = (IList)component;

            if (_iIndex >= list.Count)
            {
                return null;
            }
            else
            {
                return list[_iIndex];
            }
        }

        #region "Required overrides"

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        #endregion
    }
}