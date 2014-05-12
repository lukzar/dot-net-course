using System;
using ContextHelp;
using System.Windows.Forms;

namespace PomocKontekstowa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new Window());
        }
    }

    internal class MessageFilter : IMessageFilter
    {
        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x100 :
                    if (m.WParam.ToInt32() == (int) Keys.F1)
                    {
                        HelpUtility.ProcessHelpRequest(Control.FromHandle(m.HWnd));

                        return true;
                    }
                    break;
            }

            return false;
        }
    }
}