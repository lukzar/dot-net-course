using System;
using ContextHelp;
using System.Windows.Forms;
using System.ComponentModel;

namespace PomocKontekstowa
{
    public class ContextHelpForm : Form, IContextHelp
    {
        public virtual string ContextHelpID 
        { 
            get 
            { 
                return GetType().FullName; 
            } 
        }

        protected override void OnHelpButtonClicked(CancelEventArgs e)
        {
            HelpUtility.ProcessHelpRequest(this);

            base.OnHelpButtonClicked(e);

            e.Cancel = true;
        }
    }
}