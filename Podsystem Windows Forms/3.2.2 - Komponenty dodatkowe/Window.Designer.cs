namespace KomponentyDodatkowe
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.MousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuProgramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProgramExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MousePosition});
            this.StatusBar.Location = new System.Drawing.Point(0, 296);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(568, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // MousePosition
            // 
            this.MousePosition.Name = "MousePosition";
            this.MousePosition.Size = new System.Drawing.Size(0, 17);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 24);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(568, 272);
            this.Canvas.TabIndex = 1;
            this.Canvas.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProgramItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(568, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuProgramItem
            // 
            this.MenuProgramItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProgramExitItem});
            this.MenuProgramItem.Name = "MenuProgramItem";
            this.MenuProgramItem.Size = new System.Drawing.Size(65, 20);
            this.MenuProgramItem.Text = "Program";
            // 
            // MenuProgramExitItem
            // 
            this.MenuProgramExitItem.Name = "MenuProgramExitItem";
            this.MenuProgramExitItem.Size = new System.Drawing.Size(92, 22);
            this.MenuProgramExitItem.Text = "Exit";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 318);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Komponenty dodatkowe";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ToolStripStatusLabel MousePosition;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuProgramItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProgramExitItem;

    }
}

