﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.AvaFilters
{
    public class Caramel
    {
        public void Init()
        {
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
