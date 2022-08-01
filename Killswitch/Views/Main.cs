using RSBot.Core;
using System.Diagnostics;
using System.Windows.Forms;

namespace Killswitch.Views
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();

            txtProcessName.Text = GlobalConfig.Get("Killswitch.ProcessName", GlobalConfig.Get("RSBot.SilkroadExecutable", "sro_client.exe"));
            checkKillswitchEnabled.Checked = GlobalConfig.Get<bool>("Killswitch.Enabled");
            checkShowDialog.Checked = GlobalConfig.Get<bool>("Killswitch.ShowDialog");

            lblHeadline.Text = $"Killswitch v{KillswitchPlugin.Version}";
        }

        #region Events

        /// <summary>
        /// Handles the TextChanged event of the txtProcessName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtProcessName_TextChanged(object sender, System.EventArgs e)
        {
            GlobalConfig.Set("Killswitch.ProcessName", txtProcessName.Text);
        }

        /// <summary>
        /// Handles the CheckedChanged event of the checkbox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void settings_CheckedChanged(object sender, System.EventArgs e)
        {
            GlobalConfig.Set("Killswitch.Enabled", checkKillswitchEnabled.Checked);
            GlobalConfig.Set("Killswitch.ShowDialog", checkShowDialog.Checked);
        }

        /// <summary>
        /// Handles the Click event of the btnKillAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnKillAll_Click(object sender, System.EventArgs e)
        {
            var name = txtProcessName.Text;
            if (name.EndsWith(".exe"))
                name = name.Split('.')[0];

            foreach (var process in Process.GetProcessesByName(name))
                process.Kill();
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkGithub control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ngoedde/rsbot-killswitch") { UseShellExecute = true });
        }

        #endregion Events
    }
}