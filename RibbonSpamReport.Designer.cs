namespace OutlookSPAMReport
{
    partial class RibbonSpamReport : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonSpamReport()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.TabReadMessage = this.Factory.CreateRibbonTab();
            this.groupSpamReport = this.Factory.CreateRibbonGroup();
            this.buttonReportSpam = this.Factory.CreateRibbonButton();
            this.buttonReportHam = this.Factory.CreateRibbonButton();
            this.buttonSettings = this.Factory.CreateRibbonButton();
            this.TabMail = this.Factory.CreateRibbonTab();
            this.TabReadMessage.SuspendLayout();
            this.groupSpamReport.SuspendLayout();
            this.TabMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabReadMessage
            // 
            this.TabReadMessage.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.TabReadMessage.ControlId.OfficeId = "TabReadMessage";
            this.TabReadMessage.Label = "TabReadMessage";
            this.TabReadMessage.Name = "TabReadMessage";
            // 
            // groupSpamReport
            // 
            this.groupSpamReport.Items.Add(this.buttonReportSpam);
            this.groupSpamReport.Items.Add(this.buttonReportHam);
            this.groupSpamReport.Items.Add(this.buttonSettings);
            this.groupSpamReport.Label = "Spam Report";
            this.groupSpamReport.Name = "groupSpamReport";
            // 
            // buttonReportSpam
            // 
            this.buttonReportSpam.Label = AllResources.buttonReportSpamLabel;
            this.buttonReportSpam.Name = "buttonReportSpam";
            this.buttonReportSpam.OfficeImageId = "JunkEmailOptions";
            this.buttonReportSpam.ShowImage = true;
            this.buttonReportSpam.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReportSpam_Click);
            // 
            // buttonReportHam
            // 
            this.buttonReportHam.Label = AllResources.buttonReportHamLabel;
            this.buttonReportHam.Name = "buttonReportHam";
            this.buttonReportHam.OfficeImageId = "JunkEmailMarkAsNotJunk";
            this.buttonReportHam.ShowImage = true;
            this.buttonReportHam.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReportHam_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Label = AllResources.buttonSettingsLabel;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.OfficeImageId = "AddInCommandsMenu";
            this.buttonSettings.ShowImage = true;
            this.buttonSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSettings_Click);
            // 
            // TabMail
            // 
            this.TabMail.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.TabMail.ControlId.OfficeId = "TabMail";
            this.TabMail.Groups.Add(this.groupSpamReport);
            this.TabMail.Label = "TabMail";
            this.TabMail.Name = "TabMail";
            // 
            // RibbonSpamReport
            // 
            this.Name = "RibbonSpamReport";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.TabReadMessage);
            this.Tabs.Add(this.TabMail);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonSpamReport_Load);
            this.TabReadMessage.ResumeLayout(false);
            this.TabReadMessage.PerformLayout();
            this.groupSpamReport.ResumeLayout(false);
            this.groupSpamReport.PerformLayout();
            this.TabMail.ResumeLayout(false);
            this.TabMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabReadMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSpamReport;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReportSpam;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReportHam;
        private Microsoft.Office.Tools.Ribbon.RibbonTab TabMail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSettings;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonSpamReport ribbonSpamReport
        {
            get { return this.GetRibbon<RibbonSpamReport>(); }
        }
    }
}
