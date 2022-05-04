using System.Diagnostics;
using RSBot.Core;
using System.Windows.Forms;

namespace Killswitch.Views
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();

            txtProcessName.Text = GlobalConfig.Get("Killswitch.ProcessName", "sro_client.exe");
            checkKillswitchEnabled.Checked = GlobalConfig.Get<bool>("Killswitch.Enabled");
        }

        #region Events

        private void txtProcessName_TextChanged(object sender, System.EventArgs e)
        {
            GlobalConfig.Set("Killswitch.ProcessName", txtProcessName.Text);
        }

        private void checkKillswitchEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            GlobalConfig.Set("Killswitch.Enabled", checkKillswitchEnabled.Checked);
        }

        private void btnKillAll_Click(object sender, System.EventArgs e)
        {
            var name = txtProcessName.Text;
            if (name.EndsWith(".exe"))
                name = name.Split('.')[0];

            foreach (var process in Process.GetProcessesByName(name))
                process.Kill();
        }

        #endregion Events
    }
}