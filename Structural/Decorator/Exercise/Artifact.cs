using System;

namespace DesignPatterns.Structural.Decorator.Exercise
{
    public class Artifact : IArtifact
    {
        private string name;

        public Artifact(string name)
        {
            this.name = name;
        }

        public string Render()
        {
            return name;
        }
    }
}