namespace WlasnyFormant
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new WlasnyFormant.SmoothProgressBar();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProgressBar.Color = System.Drawing.Color.Blue;
            this.ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar.Max = 100;
            this.ProgressBar.Min = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(284, 62);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Value = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 62);
            this.Controls.Add(this.ProgressBar);
            this.MaximizeBox = false;
            this.Name = "Window";
            this.Text = "Smooth Progressbar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private SmoothProgressBar ProgressBar;

    }
}

