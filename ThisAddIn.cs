using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using OfficeRibbon = Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace OutlookSPAMReport
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        ///
        /// Gets the mail item selected in the explorer view if one is selected or instance if that is the view active.
        ///
        /// The instance containing the event data.
        /// A Outlook.MailItem for the mail being viewed.
        private IEnumerable<Outlook.MailItem> GetSelectedEmails()
        {
            Outlook.Application outlookApp = this.Application;
            Outlook.Selection selectedItems = outlookApp.ActiveExplorer().Selection;

            foreach (Outlook.MailItem email in selectedItems)
            {
                if (email is Outlook.MailItem)
                {
                    yield return email as Outlook.MailItem;
                }
            }
    }

        public void ReportSpam(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application outlookApp = this.Application;

            DialogResult result = MessageBox.Show("Do you want report spam?", "Spam Reporter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            IEnumerable<Outlook.MailItem> selectedEmails = GetSelectedEmails();
            try
            {
                Outlook.MailItem spamReportMailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                string storeID = outlookApp.ActiveExplorer().CurrentFolder.StoreID;
                foreach (Outlook.Account account in outlookApp.Session.Accounts)
                {
                    if (account.DeliveryStore.StoreID == storeID)
                    {
                        spamReportMailItem.SendUsingAccount = account;
                        break;
                    }
                }

                spamReportMailItem.Body = "Report spam";
                spamReportMailItem.Subject = "Report spam";
                spamReportMailItem.To = appSettings.Default.SpamTo;
                foreach (Outlook.MailItem oneEmail in selectedEmails)
                {
                    spamReportMailItem.Attachments.Add(oneEmail, Outlook.OlAttachmentType.olEmbeddeditem);
                }
                spamReportMailItem.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Outlook.MailItem oneEmail in selectedEmails)
            {
                try
                {
                    Outlook.Folder parentFolder = (Outlook.Folder)oneEmail.Parent;
                    Outlook.Store itemStore = parentFolder.Store;
                    Outlook.MAPIFolder junkFolder = itemStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderJunk);
                    if (parentFolder.FolderPath != junkFolder.FolderPath)
                    {
                        oneEmail.Move(junkFolder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ReportHam(object sender, RibbonControlEventArgs e)
        {
            Outlook.Application outlookApp = this.Application;

            DialogResult result = MessageBox.Show("Do you want report ham?", "Spam Reporter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            IEnumerable<Outlook.MailItem> selectedEmails = GetSelectedEmails();
            try
            {
                Outlook.MailItem hamReportMailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                string storeID = outlookApp.ActiveExplorer().CurrentFolder.StoreID;
                foreach (Outlook.Account account in outlookApp.Session.Accounts)
                {
                    if (account.DeliveryStore.StoreID == storeID)
                    {
                        hamReportMailItem.SendUsingAccount = account;
                        break;
                    }
                }


                hamReportMailItem.Body = "Report ham";
                hamReportMailItem.Subject = "Report ham";
                hamReportMailItem.To = appSettings.Default.HamTo;
                foreach (Outlook.MailItem oneEmail in selectedEmails)
                {
                    hamReportMailItem.Attachments.Add(oneEmail, Outlook.OlAttachmentType.olEmbeddeditem);
                }
                hamReportMailItem.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Outlook.MailItem oneEmail in selectedEmails)
            {
                try
                {
                    Outlook.Folder parentFolder = (Outlook.Folder)oneEmail.Parent;
                    Outlook.Store itemStore = parentFolder.Store;
                    Outlook.MAPIFolder inboxFolder = itemStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
                    if (parentFolder.FolderPath != inboxFolder.FolderPath)
                    {
                        oneEmail.Move(inboxFolder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ShowSettings(object sender, RibbonControlEventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
