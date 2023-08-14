using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton.Exercise
{
    public class Logger
    {
        private string fileName;

        private static Dictionary<string, Logger> instances = new Dictionary<string, Logger>();
        private Logger(string fileName)
        {
            this.fileName = fileName;
        }

        public void Write(string message)
        {
            Console.WriteLine("Writing a message to the log.");
        }

        public static Logger GetInstance(string fileName)
        {
            if(!instances.ContainsKey(fileName))
            {
                instances[fileName] = new Logger(fileName);
            }
            
            return instances[fileName];
        }
    }
}
