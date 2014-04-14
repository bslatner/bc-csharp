using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Org.BouncyCastle
{
    class ArrayList : List<object>
    {
        public ArrayList()
        {
            
        }

        public ArrayList(ICollection collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public object ToArray(Type type)
        {
            if (type != typeof (string))
            {
                throw new InvalidOperationException("Conversion to array of type other than string not supported");
            }

            return this.Select(x => x.ToString()).ToArray();
        }
    }
}
