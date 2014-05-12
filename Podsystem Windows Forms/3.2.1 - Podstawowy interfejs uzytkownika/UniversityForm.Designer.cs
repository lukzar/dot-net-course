using System.Windows.Forms;
namespace PodstawowyInterfejsUzytkownika
{
    partial class UniversityChoiceWindow
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
            this.UniversityGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressUniversity = new System.Windows.Forms.TextBox();
            this.NameUniversity = new System.Windows.Forms.TextBox();
            this.AddressUniversityLabel = new System.Windows.Forms.Label();
            this.NameUniversityLabel = new System.Windows.Forms.Label();
            this.TypeStudyGroupBox = new System.Windows.Forms.GroupBox();
            this.ComplementaryStudies = new System.Windows.Forms.CheckBox();
            this.FullTimeStudies = new System.Windows.Forms.CheckBox();
            this.TypeStudyComboBox = new System.Windows.Forms.ComboBox();
            this.TypeStudyLabel = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.UniversityGroupBox.SuspendLayout();
            this.TypeStudyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UniversityGroupBox
            // 
            this.UniversityGroupBox.Controls.Add(this.AddressUniversity);
            this.UniversityGroupBox.Controls.Add(this.NameUniversity);
            this.UniversityGroupBox.Controls.Add(this.AddressUniversityLabel);
            this.UniversityGroupBox.Controls.Add(this.NameUniversityLabel);
            this.UniversityGroupBox.Location = new System.Drawing.Point(13, 13);
            this.UniversityGroupBox.Name = "UniversityGroupBox";
            this.UniversityGroupBox.Size = new System.Drawing.Size(422, 80);
            this.UniversityGroupBox.TabIndex = 0;
            this.UniversityGroupBox.TabStop = false;
            this.UniversityGroupBox.Text = "Uczelnia";
            // 
            // AddressUniversity
            // 
            this.AddressUniversity.Location = new System.Drawing.Point(73, 50);
            this.AddressUniversity.Name = "AddressUniversity";
            this.AddressUniversity.Size = new System.Drawing.Size(338, 20);
            this.AddressUniversity.TabIndex = 3;
            // 
            // NameUniversity
            // 
            this.NameUniversity.Location = new System.Drawing.Point(73, 21);
            this.NameUniversity.Name = "NameUniversity";
            this.NameUniversity.Size = new System.Drawing.Size(338, 20);
            this.NameUniversity.TabIndex = 2;
            // 
            // AddressUniversityLabel
            // 
            this.AddressUniversityLabel.AutoSize = true;
            this.AddressUniversityLabel.Location = new System.Drawing.Point(6, 50);
            this.AddressUniversityLabel.Name = "AddressUniversityLabel";
            this.AddressUniversityLabel.Size = new System.Drawing.Size(37, 13);
            this.AddressUniversityLabel.TabIndex = 1;
            this.AddressUniversityLabel.Text = "Adres:";
            // 
            // NameUniversityLabel
            // 
            this.NameUniversityLabel.AutoSize = true;
            this.NameUniversityLabel.Location = new System.Drawing.Point(6, 21);
            this.NameUniversityLabel.Name = "NameUniversityLabel";
            this.NameUniversityLabel.Size = new System.Drawing.Size(43, 13);
            this.NameUniversityLabel.TabIndex = 0;
            this.NameUniversityLabel.Text = "Nazwa:";
            // 
            // TypeStudyGroupBox
            // 
            this.TypeStudyGroupBox.Controls.Add(this.ComplementaryStudies);
            this.TypeStudyGroupBox.Controls.Add(this.FullTimeStudies);
            this.TypeStudyGroupBox.Controls.Add(this.TypeStudyComboBox);
            this.TypeStudyGroupBox.Controls.Add(this.TypeStudyLabel);
            this.TypeStudyGroupBox.Location = new System.Drawing.Point(13, 100);
            this.TypeStudyGroupBox.Name = "TypeStudyGroupBox";
            this.TypeStudyGroupBox.Size = new System.Drawing.Size(422, 74);
            this.TypeStudyGroupBox.TabIndex = 1;
            this.TypeStudyGroupBox.TabStop = false;
            this.TypeStudyGroupBox.Text = "Rodzaj studiów";
            // 
            // ComplementaryStudies
            // 
            this.ComplementaryStudies.AutoSize = true;
            this.ComplementaryStudies.Location = new System.Drawing.Point(142, 47);
            this.ComplementaryStudies.Name = "ComplementaryStudies";
            this.ComplementaryStudies.Size = new System.Drawing.Size(93, 17);
            this.ComplementaryStudies.TabIndex = 3;
            this.ComplementaryStudies.Text = "uzupełniające";
            this.ComplementaryStudies.UseVisualStyleBackColor = true;
            // 
            // FullTimeStudies
            // 
            this.FullTimeStudies.AutoSize = true;
            this.FullTimeStudies.Location = new System.Drawing.Point(73, 48);
            this.FullTimeStudies.Name = "FullTimeStudies";
            this.FullTimeStudies.Size = new System.Drawing.Size(63, 17);
            this.FullTimeStudies.TabIndex = 2;
            this.FullTimeStudies.Text = "dzienne";
            this.FullTimeStudies.UseVisualStyleBackColor = true;
            // 
            // TypeStudyComboBox
            // 
            this.TypeStudyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeStudyComboBox.FormattingEnabled = true;
            this.TypeStudyComboBox.Location = new System.Drawing.Point(73, 20);
            this.TypeStudyComboBox.Name = "TypeStudyComboBox";
            this.TypeStudyComboBox.Size = new System.Drawing.Size(338, 21);
            this.TypeStudyComboBox.TabIndex = 1;
            // 
            // TypeStudyLabel
            // 
            this.TypeStudyLabel.AutoSize = true;
            this.TypeStudyLabel.Location = new System.Drawing.Point(7, 23);
            this.TypeStudyLabel.Name = "TypeStudyLabel";
            this.TypeStudyLabel.Size = new System.Drawing.Size(59, 13);
            this.TypeStudyLabel.TabIndex = 0;
            this.TypeStudyLabel.Text = "Cykl nauki:";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(13, 180);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Akceptuj";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptClick);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(360, 180);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // UniversityChoiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 210);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.TypeStudyGroupBox);
            this.Controls.Add(this.UniversityGroupBox);
            this.MaximizeBox = false;
            this.Name = "UniversityChoiceWindow";
            this.Text = "Wybór uczelni";
            this.UniversityGroupBox.ResumeLayout(false);
            this.UniversityGroupBox.PerformLayout();
            this.TypeStudyGroupBox.ResumeLayout(false);
            this.TypeStudyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UniversityGroupBox;
        private System.Windows.Forms.Label NameUniversityLabel;
        private System.Windows.Forms.Label AddressUniversityLabel;
        private System.Windows.Forms.TextBox AddressUniversity;
        private System.Windows.Forms.TextBox NameUniversity;
        private System.Windows.Forms.GroupBox TypeStudyGroupBox;
        private System.Windows.Forms.Label TypeStudyLabel;
        private System.Windows.Forms.ComboBox TypeStudyComboBox;
        private System.Windows.Forms.CheckBox ComplementaryStudies;
        private System.Windows.Forms.CheckBox FullTimeStudies;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
    }
}

