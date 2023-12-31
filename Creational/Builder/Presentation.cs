﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Presentation
    {
        private List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            builder.AddSlide(new Slide("Copyright"));
            foreach (var slide in slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}
