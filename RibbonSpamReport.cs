using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Threading;
using System.Globalization;

namespace OutlookSPAMReport
{
    public partial class RibbonSpamReport
    {
        private void RibbonSpamReport_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void buttonReportSpam_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ReportSpam(sender, e);
        }

        private void buttonReportHam_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ReportHam(sender, e);
        }

        private void buttonSettings_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowSettings(sender, e);
        }
    }
}
