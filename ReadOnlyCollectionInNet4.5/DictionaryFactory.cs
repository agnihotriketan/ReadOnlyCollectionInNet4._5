using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionInNet4._5
{
    public class DictionaryFactory
    {

        public Dictionary<string, int> _Configs;
        public DictionaryFactory()
        {
            _Configs = new Dictionary<string, int>();
            _Configs.Add("key", 1);
            _Configs.Add("key1", 2);
            _Configs["key2"] = 2;
        }
        public ReadOnlyDictionary<string, int> Configuration
        {
            get
            {
                return new ReadOnlyDictionary<string, int>(_Configs); 
            }
        }

    }
}
