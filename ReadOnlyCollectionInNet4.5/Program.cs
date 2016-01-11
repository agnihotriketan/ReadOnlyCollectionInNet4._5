using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionInNet4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DictionaryFactory obj = new DictionaryFactory();
                obj._Configs.Add("temp", 3);
                var x = obj.Configuration;
                Console.WriteLine("Readonly dictionary used to ensure the data is not modified across the app while passing data ");
                foreach (var item in x)
                {
                    Console.WriteLine(item.Key + " -- "+ item.Value);
                }
            }
            catch (Exception e)
            {
                
                throw;
            }
           
        }
    }
}
