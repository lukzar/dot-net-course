using System;
using ContextHelp;
using System.Windows.Forms;

namespace ContextHelpControls
{
    public class ContextHelpTextBox: TextBox, IContextHelp
    {
        public string ContextHelpID 
        {
            get 
            {
                return Name;
            }
        }
    }
}