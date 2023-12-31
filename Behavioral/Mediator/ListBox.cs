﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ListBox : UIControl
    {
        private string selection;

        public string GetSelection()
        {
            return selection;
        }
       
        public void SetSelection(string value)
        {
            selection = value;
            Notify(this, "listbox");
        }
    }
}
