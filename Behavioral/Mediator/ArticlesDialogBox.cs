using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ArticlesDialogBox : IObserver
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            articlesListBox.Attach(this);
            titleTextBox.Attach(this);
            saveButton.Attach(this);
        }

        private void TitleChanged()
        {
            var content = titleTextBox.GetContent();
            var isEmpty = string.IsNullOrEmpty(content);
            saveButton.SetEnabled(!isEmpty);
        }

        private void ArticleSelected()
        {
            titleTextBox.SetContent(articlesListBox.GetSelection());
            saveButton.SetEnabled(true);
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.SetSelection("Article 1");
            Console.WriteLine("Textbox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
            articlesListBox.SetSelection("Article 2");
            Console.WriteLine("Textbox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
            titleTextBox.SetContent("");
            Console.WriteLine("Button: " + saveButton.IsEnabled());
        }

        public void Update(object sender, string ev)
        {
            if (ev.Equals("textbox"))
            {
                TitleChanged();
            }
            else if(ev.Equals("listbox"))
            {
                ArticleSelected();
            }
        }
    }
}
