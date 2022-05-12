using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBagSample
{
    public class FormBag : DynamicObject
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            properties.Add(binder.Name, value);
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            if (properties.ContainsKey(binder.Name))
            {
                result = properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
    }
}
