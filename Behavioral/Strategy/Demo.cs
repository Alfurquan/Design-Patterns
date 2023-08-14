using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Demo
    {
        public static void Run()
        {
            var imageStorage = new ImageStorage();
            imageStorage.StoreImage("a", new BWFilter(), new JPEGCompressor());
        }
    }
}
