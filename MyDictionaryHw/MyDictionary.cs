using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryHw
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArrayKey = keys;
            TValue[] tempArrayValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];

            }

            keys[keys.Length-1] = key;

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                values[i] = tempArrayValue[i];

            }
            values[values.Length-1] = value;


        }

        public TKey[] Key
        {
            get { return keys; }

        }
        public TValue[] Values
        {
            get { return values; }
        }

        
    }
}
