using Killswitch.Views;
using RSBot.Core;
using RSBot.Core.Plugins;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killswitch
{
    public class KillswitchPlugin : IPlugin
    {
        #region Properties

        public PluginInfo Information => new()
        {
            DisplayAsTab = false,
            DisplayName = "Killswitch",
            InternalName = "Killswitch",
            LoadIndex = 1,
            RequireIngame = false
        };

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public static Version Version => new (1, 0, 0);

        #endregion Properties

        #region Methods

        public void Initialize()
        {
            Log.Notify("[Killswitch] Plugin initialized!");

            CheckForProcesses();
        }

        public Control GetView()
        {
            Globals.View = new Main();

            return Globals.View;
        }

        public void Translate()
        {
            LanguageManager.Translate(GetView(), Kernel.Language);
        }

        /// <summary>
        /// Checks for silkroad processes and kills them if the user confirms the dialog.
        /// </summary>
        private void CheckForProcesses()
        {
            if (!GlobalConfig.Get<bool>("Killswitch.Enabled"))
            {
                Log.Notify("[Killswitch] Process killer not active, skipping killer.");

                return;
            }

            var processName = GlobalConfig.Get("Killswitch.ProcessName", GlobalConfig.Get<string>("RSBot.SilkroadExecutable"));
            var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName));

            if (processes.Length == 0)
            {
                Log.Notify($"[Killswitch] No processes by name {processName} found, skipping killer.");

                return;
            }

            Log.Notify($"[Killswitch] Found {processes.Length} [{processName}] processes");

            //Do not interrupt the actual bot booting up by showing a dialog message
            Task.Run(() =>
            {
                if (GlobalConfig.Get<bool>("Killswitch.ShowDialog"))
                    if (MessageBox.Show($@"Found {processes.Length} silkroad processes, do you want to kill them now?",
                            @"Killswitch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                foreach (var process in processes)
                    try { process.Kill(); }
                    catch (Exception ex) { Log.Error($"[Killswitch] Could not kill process {process.Id}: {ex.Message}"); }
            });
        }

        #endregion Methods
    }
}