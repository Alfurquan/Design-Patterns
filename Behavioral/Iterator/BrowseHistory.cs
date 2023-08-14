using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class BrowseHistory
    {
        class ListIterator : IIterator<string>
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public bool HasNext()
            {
                return index < history.urls.Count;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public void Next()
            {
                index++;
            }
        }

        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return lastUrl;
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
    }

}
