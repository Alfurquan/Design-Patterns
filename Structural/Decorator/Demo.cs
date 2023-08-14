using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Demo
    {
        public static void Run() 
        {
           StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));
        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
