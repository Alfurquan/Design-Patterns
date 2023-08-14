using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Exercise
{
    public class Document
    {
        public string Content { get; set; }

        public string FontName { get; set; }

        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString()
        {
            return "Document{" +
                "content='" + Content + '\'' +
                ", fontName='" + FontName + '\'' +
                ", fontSize=" + FontSize +
                '}';
        }

    }
}
