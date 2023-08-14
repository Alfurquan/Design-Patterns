using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Exercise
{
    public class Demo
    {
        public static void Run()
        {
            var file = WavFile.Read("file.wav");
            file.Execute(new ReduceNoiseOperation());
            file.Execute(new AddReverbOperation());
            file.Execute(new NormalizeOperation());
        }
    }
}
