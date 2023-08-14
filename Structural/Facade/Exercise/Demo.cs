using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var service = new TweetService();
            service.GetRecentTweets();
        }
    }
}
