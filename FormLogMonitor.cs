//Log Monitor 1.0
//09-11-2017
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogMonitor
{
    public partial class FormLogMonitor : Form
    {
        long LogSize = 0;
        List <byte[]> SearchPaterns = new List<byte[]>();
        const int MESSAGEMAXLENGTH = 120;

        public FormLogMonitor()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(FormLogMonitor_DragEnter);
            this.DragDrop += new DragEventHandler(FormLogMonitor_DragDrop);
        }

        private void ButtonOpenLog_Click(object sender, EventArgs e)
        {
            openFileDialogLogFile.InitialDirectory = ".";
            openFileDialogLogFile.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            openFileDialogLogFile.FilterIndex = 1;
            openFileDialogLogFile.RestoreDirectory = true;
            openFileDialogLogFile.FileName = String.Empty;

            if (openFileDialogLogFile.ShowDialog() == DialogResult.OK)
            {
                textBoxLogFilePath.Text = openFileDialogLogFile.FileName;
                buttonStart.Enabled = true;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timerLogMonitor.Start();
            LogSize = new FileInfo(textBoxLogFilePath.Text).Length;
            notifyIconMessage.Visible = false;
            notifyIconMessage.BalloonTipTitle = "Log Monitor: " + Path.GetFileName(textBoxLogFilePath.Text);
            List<string> paterns = textBoxSearchPatern.Text.Split(',').ToList();
            foreach (string patern in paterns)
            {
                SearchPaterns.Add(Encoding.UTF8.GetBytes(patern));
            }
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
            textBoxSearchPatern.Enabled = false;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timerLogMonitor.Stop();
            notifyIconMessage.Visible = false;
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            textBoxSearchPatern.Enabled = true;
        }

        private void TimerLogMonitor_Tick(object sender, EventArgs e)
        {
            timerLogMonitor.Stop();
            long length = new FileInfo(textBoxLogFilePath.Text).Length;
            if (LogSize < length)
            {

                
                byte[] buffer = new byte[length - LogSize];
                using (Stream s = new FileStream(textBoxLogFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    s.Seek(LogSize, SeekOrigin.Begin);
                    s.Read(buffer, 0, buffer.Length);

                }
                //MessageBox.Show(Encoding.UTF8.GetString(buffer));
                string messages = "";
                List<int> indexFoundPaterns = new List<int>();
                foreach (byte[] searchpatern in SearchPaterns)
                {
                    indexFoundPaterns.AddRange(IndexOfSequence(buffer, searchpatern, 0));
                }
                    
                foreach (var index in indexFoundPaterns)
                {                    
                    int messagelength = MESSAGEMAXLENGTH;
                    if (buffer.Length - index < MESSAGEMAXLENGTH)
                    {
                        messagelength = buffer.Length - index;
                    }
                    byte[] newmessage = new byte[messagelength];
                    Buffer.BlockCopy(buffer, index , newmessage, 0, messagelength);
                    messages += Encoding.UTF8.GetString(newmessage) + "...\n";
                }
                if (messages != string.Empty)
                {
                    notifyIconMessage.Visible = true;
                    notifyIconMessage.BalloonTipText = messages;
                    notifyIconMessage.ShowBalloonTip(1000);
                }

                LogSize = length;
            }


            timerLogMonitor.Start();
        }

        private List<int> IndexOfSequence(byte[] buffer, byte[] pattern, int startIndex)
        {
            List<int> positions = new List<int>();
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    positions.Add(i);
                i = Array.IndexOf<byte>(buffer, pattern[0], i + pattern.Length);
            }
            return positions;
        }

        private void NotifyIconMessage_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", textBoxLogFilePath.Text);
        }

        void FormLogMonitor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void FormLogMonitor_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                textBoxLogFilePath.Text = file;
            }
            buttonStart.Enabled = true;
        }

    }
}
