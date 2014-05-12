namespace PomocKontekstowa
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ContactTab = new System.Windows.Forms.TabPage();
            this.Contact = new PomocKontekstowa.Contact();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.Order = new PomocKontekstowa.Order();
            this.Tabs.SuspendLayout();
            this.ContactTab.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.ContactTab);
            this.Tabs.Controls.Add(this.OrderTab);
            this.Tabs.Location = new System.Drawing.Point(5, 7);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(437, 276);
            this.Tabs.TabIndex = 0;
            // 
            // ContactTab
            // 
            this.ContactTab.Controls.Add(this.Contact);
            this.ContactTab.Location = new System.Drawing.Point(4, 22);
            this.ContactTab.Name = "ContactTab";
            this.ContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTab.Size = new System.Drawing.Size(429, 250);
            this.ContactTab.TabIndex = 0;
            this.ContactTab.Text = "Contact";
            this.ContactTab.UseVisualStyleBackColor = true;
            // 
            // Contact
            // 
            this.Contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact.Location = new System.Drawing.Point(3, 3);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(423, 244);
            this.Contact.TabIndex = 0;
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.Order);
            this.OrderTab.Location = new System.Drawing.Point(4, 22);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(429, 250);
            this.OrderTab.TabIndex = 1;
            this.OrderTab.Text = "Order";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order.Location = new System.Drawing.Point(3, 3);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(423, 244);
            this.Order.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.Tabs);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window";
            this.Tabs.ResumeLayout(false);
            this.ContactTab.ResumeLayout(false);
            this.OrderTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ContactTab;
        private System.Windows.Forms.TabPage OrderTab;
        private Contact Contact;
        private Order Order;
    }
}