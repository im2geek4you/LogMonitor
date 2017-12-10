namespace LogMonitor
{
    partial class FormLogMonitor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogMonitor));
            this.buttonOpenLog = new System.Windows.Forms.Button();
            this.textBoxLogFilePath = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialogLogFile = new System.Windows.Forms.OpenFileDialog();
            this.notifyIconMessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxSearchPatern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLogMonitor = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenLog
            // 
            this.buttonOpenLog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOpenLog.Location = new System.Drawing.Point(408, 19);
            this.buttonOpenLog.Name = "buttonOpenLog";
            this.buttonOpenLog.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenLog.TabIndex = 0;
            this.buttonOpenLog.Text = "Open Log";
            this.buttonOpenLog.UseVisualStyleBackColor = true;
            this.buttonOpenLog.Click += new System.EventHandler(this.ButtonOpenLog_Click);
            // 
            // textBoxLogFilePath
            // 
            this.textBoxLogFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogFilePath.Enabled = false;
            this.textBoxLogFilePath.Location = new System.Drawing.Point(12, 20);
            this.textBoxLogFilePath.Name = "textBoxLogFilePath";
            this.textBoxLogFilePath.Size = new System.Drawing.Size(388, 20);
            this.textBoxLogFilePath.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(327, 56);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // openFileDialogLogFile
            // 
            this.openFileDialogLogFile.Filter = "Log Files (*.Log)|*.Log";
            // 
            // notifyIconMessage
            // 
            this.notifyIconMessage.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIconMessage.BalloonTipTitle = "Log Monitor";
            this.notifyIconMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMessage.Icon")));
            this.notifyIconMessage.Visible = true;
            this.notifyIconMessage.BalloonTipClicked += new System.EventHandler(this.NotifyIconMessage_BalloonTipClicked);
            // 
            // textBoxSearchPatern
            // 
            this.textBoxSearchPatern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPatern.Location = new System.Drawing.Point(12, 56);
            this.textBoxSearchPatern.Name = "textBoxSearchPatern";
            this.textBoxSearchPatern.Size = new System.Drawing.Size(304, 20);
            this.textBoxSearchPatern.TabIndex = 3;
            this.textBoxSearchPatern.Text = "ERROR,WARN,Exception";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log Path";
            // 
            // timerLogMonitor
            // 
            this.timerLogMonitor.Tick += new System.EventHandler(this.TimerLogMonitor_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(408, 56);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // FormLogMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 88);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearchPatern);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxLogFilePath);
            this.Controls.Add(this.buttonOpenLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 127);
            this.MinimumSize = new System.Drawing.Size(511, 127);
            this.Name = "FormLogMonitor";
            this.Text = "Log Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenLog;
        private System.Windows.Forms.TextBox textBoxLogFilePath;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogFile;
        private System.Windows.Forms.NotifyIcon notifyIconMessage;
        private System.Windows.Forms.TextBox textBoxSearchPatern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerLogMonitor;
        private System.Windows.Forms.Button buttonStop;
    }
}

