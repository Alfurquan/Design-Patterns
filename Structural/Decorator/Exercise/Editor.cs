using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Exercise
{
    public class Editor
    {
        public void openProject(string path)
        {
            IArtifact[] artifacts = {
                new Artifact("Main"),
                new Artifact("Demo"),
                new Artifact("EmailClient"),
                new Artifact("EmailProvider"),
        };

            artifacts[0] = new ErrorDecorator(new MainDecorator(artifacts[0]));
            artifacts[2] = new ErrorDecorator(artifacts[2]);

            foreach(var artifact in artifacts)
                Console.WriteLine(artifact.Render());
        }
    }
}
