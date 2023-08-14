using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Exercise
{
    public class AESEncryption : IEncryption
    {
        public void Encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
        }
    }
}
