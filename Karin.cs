using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarinClicker
{
    public partial class Karin : Form
    {

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Karin()
        {
            InitializeComponent();
        }

        private void Karin_Load(object sender, EventArgs e)
        {
            // Verify if Minecraft is running, if not then exit.
            Process[] processes = Process.GetProcessesByName("javaw");
            Process[] processes2 = Process.GetProcessesByName("java");
            if (processes.Length == 0 && processes2.Length == 0)
            {
                MessageBox.Show("Minecraft is not running!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            blatantmode.Visible = false;
            blatantmode_text.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Verifies if "delete on exit" is toggled, if it is then delete the executable on exit.
            if (delete_exit.Checked) { 
                string exeFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
                Process.Start("del /s /q " + exeFileName);
            }
        }

        private void CPSValueScrollAction(object sender, ScrollEventArgs e)
        {
            // Sets the CPS Value text to the Selected CPS Value.
            CPSValue.Text = CPSValueScroll.Value.ToString() + " CPS";
        }

        private void LeftClicker_Tick(object sender, EventArgs e)
        {
            LeftClicker.Interval = 1000 / CPSValueScroll.Value - 7;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (clickerenabled.Checked && MouseButtons == MouseButtons.Left)
                    {
                        if (soundclicker.Checked) click();
                        SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                        Task.Delay(1).Wait();
                        SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        if (soundclicker.Checked) release();
                    }
                }
            }
        }

        public void click()
        {
            try {
                
                System.IO.Stream str = Properties.Resources.click;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                snd.Stop();
            } catch (Exception ex) {
                Console.WriteLine("Error accessing resource: " + ex.Message);
            }

        }

        public void release()
        {
            try
            {
                System.IO.Stream str = Properties.Resources.release;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                snd.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accessing resource: " + ex.Message);
            }

        }

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void soundclicker_CheckedChanged(object sender, EventArgs e)
        {
            if (soundclicker.Checked)
            {
                DialogResult dr = MessageBox.Show("Soundclicker is broken at the moment :P", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.OK:
                        soundclicker.Checked = false;
                        break;
                }
            }
        }

        private void delete_exit_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_exit.Checked)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to enable this?\nIt will delete the clicker on exit.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        delete_exit.Checked = false;
                        break;
                }
            }
        }

        private void clickerenabled_CheckedChanged(object sender, EventArgs e)
        {
            if (clickerenabled.Checked)
            {
                blatantmode.Visible = true;
                blatantmode_text.Visible = true;
                
            } else
            {
                blatantmode.Visible = false;
                blatantmode_text.Visible = false;
            }
        }

        private void blatantmode_CheckedChanged(object sender, EventArgs e)
        {
            if (blatantmode.Checked)
            {
                CPSValueScroll.Maximum = 50;
            } else
            {
                if (!(CPSValueScroll.Value < 20))
                {
                    CPSValueScroll.Value = 20;
                    CPSValue.Text = CPSValueScroll.Value + " CPS";
                }
                CPSValueScroll.Maximum = 20;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
