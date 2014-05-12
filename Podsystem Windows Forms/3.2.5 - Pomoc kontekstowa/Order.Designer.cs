namespace PomocKontekstowa
{
    partial class Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Details = new ContextHelpControls.ContextHelpTextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(3, 20);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(417, 221);
            this.Details.TabIndex = 0;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(4, 4);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(42, 13);
            this.DetailsLabel.TabIndex = 1;
            this.DetailsLabel.Text = "Details:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.Details);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(423, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextHelpControls.ContextHelpTextBox Details;
        private System.Windows.Forms.Label DetailsLabel;

    }
}
