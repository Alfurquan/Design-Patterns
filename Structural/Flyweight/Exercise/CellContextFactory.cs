using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural.Flyweight.Exercise
{
    public class CellContextFactory
    {
        private Dictionary<int, CellContext> contexts = new Dictionary<int, CellContext>();

        public CellContext GetContext(string fontFamily, int fontSize, bool isBold)
        {
            // Generate a unique key for the combination of fontFamily, fontSize and isBold attributes.
            var context = new CellContext(fontFamily, fontSize, isBold);
            var hash = context.GetHashCode();

            if (!contexts.ContainsKey(hash))
                contexts.Add(hash, context);

            return contexts[hash];
        }
    }
}
