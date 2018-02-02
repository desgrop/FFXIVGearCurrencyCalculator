namespace Currency_Calculator_FFXIV
{
    partial class mainWindow
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
            this.gearSetComboBox = new System.Windows.Forms.ComboBox();
            this.gearSetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gearSetComboBox
            // 
            this.gearSetComboBox.FormattingEnabled = true;
            this.gearSetComboBox.Location = new System.Drawing.Point(13, 37);
            this.gearSetComboBox.Name = "gearSetComboBox";
            this.gearSetComboBox.Size = new System.Drawing.Size(121, 21);
            this.gearSetComboBox.TabIndex = 0;
            // 
            // gearSetLabel
            // 
            this.gearSetLabel.AutoSize = true;
            this.gearSetLabel.Location = new System.Drawing.Point(13, 13);
            this.gearSetLabel.Name = "gearSetLabel";
            this.gearSetLabel.Size = new System.Drawing.Size(52, 13);
            this.gearSetLabel.TabIndex = 1;
            this.gearSetLabel.Text = "Gear Set ";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 287);
            this.Controls.Add(this.gearSetLabel);
            this.Controls.Add(this.gearSetComboBox);
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.Text = "FFXIV Gear Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gearSetComboBox;
        private System.Windows.Forms.Label gearSetLabel;
    }
}

