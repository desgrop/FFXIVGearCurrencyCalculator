namespace Currency_Calculator_FFXIV
{
    partial class MainWindow
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
            this.discipleComboBox = new System.Windows.Forms.ComboBox();
            this.gearSetLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // discipleComboBox
            // 
            this.discipleComboBox.FormattingEnabled = true;
            this.discipleComboBox.Location = new System.Drawing.Point(13, 29);
            this.discipleComboBox.Name = "discipleComboBox";
            this.discipleComboBox.Size = new System.Drawing.Size(121, 21);
            this.discipleComboBox.TabIndex = 0;
            this.discipleComboBox.SelectedValueChanged += new System.EventHandler(this.DiscipleComboBox_SelectedValueChanged);
            // 
            // gearSetLabel
            // 
            this.gearSetLabel.AutoSize = true;
            this.gearSetLabel.Location = new System.Drawing.Point(13, 13);
            this.gearSetLabel.Name = "gearSetLabel";
            this.gearSetLabel.Size = new System.Drawing.Size(68, 13);
            this.gearSetLabel.TabIndex = 1;
            this.gearSetLabel.Text = "Disciple of ...";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(13, 63);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            this.classLabel.Visible = false;
            // 
            // classComboBox
            // 
            this.classComboBox.Enabled = false;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(13, 79);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 287);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.gearSetLabel);
            this.Controls.Add(this.discipleComboBox);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "FFXIV Gear Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox discipleComboBox;
        private System.Windows.Forms.Label gearSetLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}

