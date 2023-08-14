using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Exercise
{
    public class ErrorDecorator : IArtifact
    {
        private IArtifact artifact;

        public ErrorDecorator(IArtifact artifact)
        {
            this.artifact = artifact;
        }

        public string Render()
        {
            var mainIcon = artifact.Render();
            return mainIcon + " [Error]";
        }
    }
}
