using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookSPAMReport
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonSettingsOK_Click(object sender, EventArgs e)
        {
            appSettings.Default["SpamTo"] = this.textBoxSpamTo.Text;
            appSettings.Default["HamTo"] = this.textBoxHamTo.Text;
            appSettings.Default.Save();
        }
    }
}
