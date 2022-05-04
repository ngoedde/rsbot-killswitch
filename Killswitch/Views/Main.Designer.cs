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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.btnKillAll = new System.Windows.Forms.Button();
            this.checkKillswitchEnabled = new System.Windows.Forms.CheckBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process name:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(34, 149);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(177, 22);
            this.txtProcessName.TabIndex = 1;
            this.txtProcessName.Text = "sro_client.exe";
            this.txtProcessName.TextChanged += new System.EventHandler(this.txtProcessName_TextChanged);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Location = new System.Drawing.Point(217, 149);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Size = new System.Drawing.Size(75, 23);
            this.btnKillAll.TabIndex = 4;
            this.btnKillAll.Text = "Kill all";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKillAll_Click);
            // 
            // checkKillswitchEnabled
            // 
            this.checkKillswitchEnabled.AutoSize = true;
            this.checkKillswitchEnabled.Location = new System.Drawing.Point(34, 177);
            this.checkKillswitchEnabled.Name = "checkKillswitchEnabled";
            this.checkKillswitchEnabled.Size = new System.Drawing.Size(257, 17);
            this.checkKillswitchEnabled.TabIndex = 5;
            this.checkKillswitchEnabled.Text = "Kill all clients when the bot application starts";
            this.checkKillswitchEnabled.UseVisualStyleBackColor = true;
            this.checkKillswitchEnabled.CheckedChanged += new System.EventHandler(this.checkKillswitchEnabled_CheckedChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(123, 222);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(98, 13);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "2022 © Wimbeam";
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(14, 18);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(60, 15);
            this.lblHeadline.TabIndex = 7;
            this.lblHeadline.Text = "Killswitch";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(14, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(287, 52);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "This tool provides the function to kill all clients\r\nwhenever the bot application" +
    " starts. Although this\r\nfeature may not be useful for the bot users themselves\r\n" +
    "it\'s nice to have as a developer.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.checkKillswitchEnabled);
            this.Controls.Add(this.btnKillAll);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Size = new System.Drawing.Size(345, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Button btnKillAll;
        private System.Windows.Forms.CheckBox checkKillswitchEnabled;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblInfo;
    }
}
