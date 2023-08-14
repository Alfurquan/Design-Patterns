using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        Movie movie = new Movie();
        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.GetText());
        }

        public Movie GetMovie()
        {
            return movie;
        }
    }
}
