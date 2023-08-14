using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Demo
    {
        public static void Run()
        {
            var configManager = ConfigManager.GetInstance();
            configManager.Set("key1", "value1");    

            var otherConfigManager = ConfigManager.GetInstance();
            Console.WriteLine(otherConfigManager.Get("key1")); // value1
        }
    }
}
