﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Exercise
{
    public class ContextMenu
    {
        private Timeline timeline;

        public ContextMenu(Timeline timeline)
        {
            this.timeline = timeline;
        }

        public void Duplicate(IComponent component)
        {
            timeline.Add(component.Clone());
        }
    }
}
