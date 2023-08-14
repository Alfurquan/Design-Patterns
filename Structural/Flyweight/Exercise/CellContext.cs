using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Structural.Flyweight.Exercise
{
    public class CellContext
    {
        private readonly string fontFamily;
        private readonly int fontSize;
        private readonly bool isBold;

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
        }

        public string GetFontFamily()
        {
            return fontFamily;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public bool IsBold()
        {
            return isBold;
        }

        public override int GetHashCode()
        {
           return this.GetHashCode();
        }
    }
}
