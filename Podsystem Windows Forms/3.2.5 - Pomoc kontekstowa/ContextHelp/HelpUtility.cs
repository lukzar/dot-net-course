using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace ContextHelp
{
    public static class HelpUtility
    {
        private static string HelpFile = "ContextHelp.chm";

        private static StringDictionary ContextPaths = new StringDictionary() 
        { 
            { "Contact", "contact.html" },
            { "Order", "order.html" },
            { "Details", "details.html" }
        };

        public static void ProcessHelpRequest(Control control)
        {
            ShowContextHelp(control);
        }

        public static void ShowContextHelp(Control control)
        {
            Control parent = control;

            string HTMLFileName = null;

            while (parent != null)
            {
                IContextHelp help = GetIContextHelpControl(parent);

                if (help == null)
                {
                    break;
                }

                if (help.ContextHelpID != null)
                {
                    HTMLFileName = LookupHTMLHelpPathFromID(help.ContextHelpID);

                    if (HTMLFileName != null && ShowHelp(control, HTMLFileName))
                    {
                        return;
                    }
                }

                parent = ((Control) help).Parent;
            }

            ShowHelp(control, "");
        }

        private static string HelpFilePath 
        { 
            get 
            { 
                return Path.Combine(Application.StartupPath, HelpFile); 
            } 
        }

        private static string LookupHTMLHelpPathFromID(string sContextID)
        {
            if (ContextPaths.ContainsKey(sContextID))
            {
                return ContextPaths[sContextID];
            }

            return null;
        }

        private static bool ShowHelp(Control control, string HTMLHelp)
        {
            try
            {
                if (string.IsNullOrEmpty(HTMLHelp))
                {
                    Help.ShowHelp(control, HelpUtility.HelpFilePath);
                }
                else
                {
                    Help.ShowHelp(control, HelpUtility.HelpFilePath, HelpNavigator.Topic, HTMLHelp);
                }
            }
            catch (ArgumentException)
            {
                return false;
            }
            
            return true;
        }

        private static IContextHelp GetIContextHelpControl(Control control)
        {
            while (control != null)
            {
                IContextHelp help = control as IContextHelp;
                
                if (help != null)
                {
                    return help;
                }

                control = control.Parent;
            }

            return null;
        }
    }
}
