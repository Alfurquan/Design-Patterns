using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.Exercise
{
    public class SpreadSheet
    {
        private int MAX_ROWS = 3;
        private int MAX_COLS = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private readonly string fontFamily = "Times New Roman";
        private readonly int fontSize = 12;
        private readonly bool isBold = false;
        private CellContextFactory contextFactory;

        private Cell[,] cells = new Cell[3,3];

        public SpreadSheet(CellContextFactory contextFactory)
        {
            GenerateCells();
            this.contextFactory = contextFactory;
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            cells[row,col].SetContent(content);
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);

            var cell = cells[row,col];
            var currentContext = cell.GetContext();
            var context = contextFactory.GetContext(fontFamily, currentContext.GetFontSize(), currentContext.IsBold());
            cells[row,col].SetContext(context);
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= this.MAX_ROWS)
                throw new Exception();

            if (col < 0 || col >= this.MAX_COLS)
                throw new Exception();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, getDefaultContext());
                    cells[row,col] = cell;
                }
        }

        private CellContext getDefaultContext()
        {
            // In a real app, these values should not be hardcoded here.
            // They should be read from a configuration file.
            return new CellContext("Times New Roman", 12, false);
        }


        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row,col].Render();
        }
    }
}
