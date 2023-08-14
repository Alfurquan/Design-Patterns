using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ImageStorage
    {
        public void StoreImage(string fileName, IFilter filter, ICompressor compressor)
        {
            compressor.Compress(fileName);

            filter.apply(fileName);
        }
    }
}
