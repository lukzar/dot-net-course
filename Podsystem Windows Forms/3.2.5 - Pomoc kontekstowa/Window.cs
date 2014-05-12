using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PomocKontekstowa
{
    public partial class Window : ContextHelpForm
    {
        public Window()
        {
            InitializeComponent();
        }

        public override string ContextHelpID
        {
            get
            {
                switch (Tabs.SelectedIndex)
                {
                    case 0: 
                        return Contact.ContextHelpID;
                    case 1: 
                        return Order.ContextHelpID;
                }

                return base.ContextHelpID;
            }
        }
    }
}