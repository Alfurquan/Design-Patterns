using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.Exercise
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private string content;
        private CellContext cellContext;

        public Cell(int row, int column, CellContext cellContext)
        {
            this.row = row;
            this.column = column;
            this.cellContext = cellContext;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void SetContext(CellContext cellContext)
        {
            this.cellContext = cellContext;
        }
       
        public CellContext GetContext()
        {
            return cellContext;
        }
       

        public void Render()
        {
            Console.WriteLine("({0}, {1}): {2} [{3}]\n", row, column, content, cellContext.GetFontFamily());
        }
    }
}
