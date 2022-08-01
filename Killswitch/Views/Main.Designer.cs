using SDUI.Controls;

namespace Killswitch.Views
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new SDUI.Controls.Label();
            this.txtProcessName = new SDUI.Controls.TextBox();
            this.btnKillAll = new SDUI.Controls.Button();
            this.checkKillswitchEnabled = new SDUI.Controls.CheckBox();
            this.lblHeadline = new SDUI.Controls.Label();
            this.lblInfo = new SDUI.Controls.Label();
            this.checkShowDialog = new SDUI.Controls.CheckBox();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process name:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(34, 149);
            this.txtProcessName.MaxLength = 32767;
            this.txtProcessName.MultiLine = false;
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(177, 20);
            this.txtProcessName.TabIndex = 1;
            this.txtProcessName.Text = "sro_client.exe";
            this.txtProcessName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProcessName.UseSystemPasswordChar = false;
            this.txtProcessName.TextChanged += new System.EventHandler(this.txtProcessName_TextChanged);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Color = System.Drawing.Color.Transparent;
            this.btnKillAll.Location = new System.Drawing.Point(217, 149);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Radius = 2;
            this.btnKillAll.Size = new System.Drawing.Size(75, 23);
            this.btnKillAll.TabIndex = 4;
            this.btnKillAll.Text = "Kill all";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKillAll_Click);
            // 
            // checkKillswitchEnabled
            // 
            this.checkKillswitchEnabled.AutoSize = true;
            this.checkKillswitchEnabled.BackColor = System.Drawing.Color.Transparent;
            this.checkKillswitchEnabled.Checked = false;
            this.checkKillswitchEnabled.Location = new System.Drawing.Point(34, 177);
            this.checkKillswitchEnabled.Name = "checkKillswitchEnabled";
            this.checkKillswitchEnabled.Size = new System.Drawing.Size(254, 13);
            this.checkKillswitchEnabled.TabIndex = 5;
            this.checkKillswitchEnabled.Text = "Kill all clients when the bot application starts";
            this.checkKillswitchEnabled.CheckedChanged += new System.EventHandler(this.settings_CheckedChanged);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeadline.Location = new System.Drawing.Point(14, 18);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(60, 15);
            this.lblHeadline.TabIndex = 7;
            this.lblHeadline.Text = "Killswitch";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(14, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(287, 52);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "This plugin provides the function to kill all clients\r\nwhenever the bot applicati" +
    "on starts. Although this\r\nfeature may not be useful for the bot users themselves" +
    "\r\nit\'s nice to have as a developer.";
            // 
            // checkShowDialog
            // 
            this.checkShowDialog.AutoSize = true;
            this.checkShowDialog.BackColor = System.Drawing.Color.Transparent;
            this.checkShowDialog.Checked = false;
            this.checkShowDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkShowDialog.Location = new System.Drawing.Point(34, 204);
            this.checkShowDialog.Name = "checkShowDialog";
            this.checkShowDialog.Size = new System.Drawing.Size(141, 13);
            this.checkShowDialog.TabIndex = 9;
            this.checkShowDialog.Text = "Show confirmation dialog";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(123, 242);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(98, 13);
            this.linkGithub.TabIndex = 10;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "2022 © Wimbeam";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.checkShowDialog);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.checkKillswitchEnabled);
            this.Controls.Add(this.btnKillAll);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(345, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtProcessName;
        private Button btnKillAll;
        private CheckBox checkKillswitchEnabled;
        private Label lblHeadline;
        private Label lblInfo;
        private CheckBox checkShowDialog;
        private System.Windows.Forms.LinkLabel linkGithub;
    }
}
