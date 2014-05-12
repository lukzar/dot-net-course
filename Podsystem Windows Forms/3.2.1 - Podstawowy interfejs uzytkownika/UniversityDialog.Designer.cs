namespace PodstawowyInterfejsUzytkownika
{
    partial class University
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
            this.NameUniversity = new System.Windows.Forms.Label();
            this.AddressUniversity = new System.Windows.Forms.Label();
            this.TypeStudy = new System.Windows.Forms.Label();
            this.FullTimeStudies = new System.Windows.Forms.Label();
            this.ComplementaryStudies = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameUniversity
            // 
            this.NameUniversity.Location = new System.Drawing.Point(13, 13);
            this.NameUniversity.Name = "NameUniversity";
            this.NameUniversity.Size = new System.Drawing.Size(206, 13);
            this.NameUniversity.TabIndex = 0;
            // 
            // AddressUniversity
            // 
            this.AddressUniversity.Location = new System.Drawing.Point(13, 34);
            this.AddressUniversity.Name = "AddressUniversity";
            this.AddressUniversity.Size = new System.Drawing.Size(206, 13);
            this.AddressUniversity.TabIndex = 1;
            // 
            // TypeStudy
            // 
            this.TypeStudy.Location = new System.Drawing.Point(13, 55);
            this.TypeStudy.Name = "TypeStudy";
            this.TypeStudy.Size = new System.Drawing.Size(206, 13);
            this.TypeStudy.TabIndex = 2;
            // 
            // FullTimeStudies
            // 
            this.FullTimeStudies.Location = new System.Drawing.Point(13, 76);
            this.FullTimeStudies.Name = "FullTimeStudies";
            this.FullTimeStudies.Size = new System.Drawing.Size(206, 13);
            this.FullTimeStudies.TabIndex = 3;
            // 
            // ComplementaryStudies
            // 
            this.ComplementaryStudies.Location = new System.Drawing.Point(13, 97);
            this.ComplementaryStudies.Name = "ComplementaryStudies";
            this.ComplementaryStudies.Size = new System.Drawing.Size(206, 13);
            this.ComplementaryStudies.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(71, 123);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 158);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ComplementaryStudies);
            this.Controls.Add(this.FullTimeStudies);
            this.Controls.Add(this.TypeStudy);
            this.Controls.Add(this.AddressUniversity);
            this.Controls.Add(this.NameUniversity);
            this.MaximizeBox = false;
            this.Name = "University";
            this.Text = "Uczelnia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameUniversity;
        private System.Windows.Forms.Label AddressUniversity;
        private System.Windows.Forms.Label TypeStudy;
        private System.Windows.Forms.Label FullTimeStudies;
        private System.Windows.Forms.Label ComplementaryStudies;
        private System.Windows.Forms.Button OKButton;

    }
}