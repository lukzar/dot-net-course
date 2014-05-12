using System;
using ContextHelp;
using System.Windows.Forms;

namespace ContextHelpControls
{
    public class ContextHelpUserControl : UserControl, IContextHelp
    {
        public virtual string ContextHelpID
        {
            get
            {
                return Name;
            }
        }
    }
}
