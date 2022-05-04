using Killswitch.Views;
using RSBot.Core;
using RSBot.Core.Plugins;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Killswitch
{
    public class Killswitch : IPlugin
    {
        public PluginInfo Information => new PluginInfo
        {
            DisplayAsTab = false,
            DisplayName = "Killswitch",
            InternalName = "Killswitch",
            LoadIndex = 1,
            RequireIngame = false
        };

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

        private void CheckForProcesses()
        {
            if (!GlobalConfig.Get<bool>("Killswitch.Enabled"))
            {
                Log.Notify("[Killswitch] Process killer not active, skipping killer.");

                return;
            }

            var processName = GlobalConfig.Get("Killswitch.ProcessName", "sro_client");
            var processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
            {
                Log.Notify("[Killswitch] No processes found, skipping killer.");

                return;
            }

            Log.Notify($"[Killswitch] Found {processes.Length} [{processName}] processes");

            if (MessageBox.Show($@"Found {processes.Length} silkroad processes, do you want to kill them now?",
                    @"Killswitch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            foreach (var process in processes)
                try { process.Kill(); }
                catch (Exception ex) { Log.Error($"[Killswitch] Could not kill process {process.Id}: {ex.Message}"); }
        }
    }
}