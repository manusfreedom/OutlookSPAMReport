namespace OutlookSPAMReport
{
    partial class SettingsForm
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
            this.textBoxSpamTo = new System.Windows.Forms.TextBox();
            this.textBoxHamTo = new System.Windows.Forms.TextBox();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.buttonSettingsCancel = new System.Windows.Forms.Button();
            this.labelSpamTo = new System.Windows.Forms.Label();
            this.labelHamTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSpamTo
            // 
            this.textBoxSpamTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OutlookSPAMReport.appSettings.Default, "SpamTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSpamTo.Location = new System.Drawing.Point(92, 12);
            this.textBoxSpamTo.Name = "textBoxSpamTo";
            this.textBoxSpamTo.Size = new System.Drawing.Size(257, 20);
            this.textBoxSpamTo.TabIndex = 0;
            this.textBoxSpamTo.Text = global::OutlookSPAMReport.appSettings.Default.SpamTo;
            // 
            // textBoxHamTo
            // 
            this.textBoxHamTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OutlookSPAMReport.appSettings.Default, "HamTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHamTo.Location = new System.Drawing.Point(92, 38);
            this.textBoxHamTo.Name = "textBoxHamTo";
            this.textBoxHamTo.Size = new System.Drawing.Size(257, 20);
            this.textBoxHamTo.TabIndex = 1;
            this.textBoxHamTo.Text = global::OutlookSPAMReport.appSettings.Default.HamTo;
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSettingsOK.Location = new System.Drawing.Point(274, 64);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsOK.TabIndex = 2;
            this.buttonSettingsOK.Text = AllResources.okText;
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // buttonSettingsCancel
            // 
            this.buttonSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSettingsCancel.Location = new System.Drawing.Point(193, 64);
            this.buttonSettingsCancel.Name = "buttonSettingsCancel";
            this.buttonSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsCancel.TabIndex = 3;
            this.buttonSettingsCancel.Text = AllResources.cancelText;
            this.buttonSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // labelSpamTo
            // 
            this.labelSpamTo.AutoSize = true;
            this.labelSpamTo.Location = new System.Drawing.Point(9, 15);
            this.labelSpamTo.Name = "labelSpamTo";
            this.labelSpamTo.Size = new System.Drawing.Size(82, 13);
            this.labelSpamTo.TabIndex = 4;
            this.labelSpamTo.Text = AllResources.labelSpamTo;
            // 
            // labelHamTo
            // 
            this.labelHamTo.AutoSize = true;
            this.labelHamTo.Location = new System.Drawing.Point(9, 41);
            this.labelHamTo.Name = "labelHamTo";
            this.labelHamTo.Size = new System.Drawing.Size(77, 13);
            this.labelHamTo.TabIndex = 5;
            this.labelHamTo.Text = AllResources.labelHamTo;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonSettingsOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSettingsCancel;
            this.ClientSize = new System.Drawing.Size(361, 97);
            this.Controls.Add(this.labelHamTo);
            this.Controls.Add(this.labelSpamTo);
            this.Controls.Add(this.buttonSettingsCancel);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.textBoxHamTo);
            this.Controls.Add(this.textBoxSpamTo);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Spam Report Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSpamTo;
        private System.Windows.Forms.TextBox textBoxHamTo;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.Button buttonSettingsCancel;
        private System.Windows.Forms.Label labelSpamTo;
        private System.Windows.Forms.Label labelHamTo;
    }
}