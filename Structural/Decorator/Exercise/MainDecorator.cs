using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Exercise
{
    public class MainDecorator : IArtifact
    {
        private IArtifact artifact;

        public MainDecorator(IArtifact artifact)
        {
            this.artifact = artifact;
        }

        public string Render()
        {
            return artifact.Render() + " [Main]";
        }
    }
}
