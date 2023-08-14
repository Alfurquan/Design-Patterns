using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var chatClient = new ChatClient();
            chatClient.send("Hello World", new AESEncryption());
        }
    }
}
