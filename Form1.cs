using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using Memory;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace Trigger_Bot
{
    public partial class Form1 : Form
    {
        #region HOOK U CSGO
        public const string WINDOW_NAME = "Counter-Strike: Global Offensive - Direct3D 9";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;
        }
        #endregion

        Mem mem = new();

        string flashduration = Offsets.client + Offsets.localPlayer + Offsets.m_flFlashDuration;
        string crossID = Offsets.client + Offsets.localPlayer + Offsets.m_iCrosshairId;
        string forceAttack = Offsets.client + Offsets.dwForceAttack;
        public Form1()
        {
            InitializeComponent();
            int PID = mem.GetProcIdFromName("csgo");
            if(PID > 0)
            {
                mem.OpenProcess(PID);
            }
            Thread tmain = new(Main) { IsBackground = true };
            tmain.Start();
        }
        void Main()
        {
            while (true)
            {
                SwitchOn();

                if(!sasaMaticEfekat.Checked)
                {
                    int flash = mem.ReadInt(flashduration);
                    if (flash > 0)
                        mem.WriteMemory(flashduration, "int", "0");
                }
                if(simplemode.Checked)
                {   
                    if(GetAsyncKeyState(Keys.ShiftKey) < 0)
                    {
                        int CrosshairID = mem.ReadInt(crossID);
                        Debug.WriteLine($"Crosshair ID is => {CrosshairID}");
                        if(CrosshairID > 0 && CrosshairID < 20)
                        {
                            mem.WriteMemory(forceAttack, "int", "6");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;


            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);



            this.Left = rect.left;
            this.Top = rect.top;
            backgroundWorker1.RunWorkerAsync();
            sasaMaticEfekat.Checked = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetWindowRect(handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

                this.Left = rect.left;
                this.Top = rect.top;

                Thread.Sleep(10);
            }
        }
        void SwitchOn()
        {
            if(GetAsyncKeyState(Keys.Insert) < 0)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void vacHavarija_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}