using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.Exercise
{
    public class Team : IResource
    {
        public List<IResource> resources = new List<IResource>();

        public void Add(IResource resource)
        {
            resources.Add(resource);
        }

        public void Deploy()
        {
            foreach (var resource in resources)
            {
                resource.Deploy();
            }
        }

    }
}
