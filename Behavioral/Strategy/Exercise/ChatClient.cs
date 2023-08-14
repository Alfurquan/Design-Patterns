using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Exercise
{
    public class ChatClient
    {
        public void send(String message, IEncryption encryptionAlgorithm)
        {
            encryptionAlgorithm.Encrypt(message);                
            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
