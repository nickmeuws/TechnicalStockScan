using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TechnicalStockScan
{
    public partial class FullScreenForm : Form
    {
        [DllImport("Coredll")]
        internal static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("coredll.dll")]
        internal static extern bool EnableWindow(IntPtr hwnd, Boolean bEnable);

        [DllImport("coredll.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);

        public FullScreenForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            HideHHTaskBar();
            SetFullscreen();
        }

        public static void HideHHTaskBar()
        {
            IntPtr iptrTB = FindWindow("HHTaskBar", null);
            MoveWindow(iptrTB, 0, Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Width, 26, true);
        }

        public static void SetHHTaskBar()
        {
            IntPtr iptrTB = FindWindow("HHTaskBar", null);
            MoveWindow(iptrTB, 0, 294, Screen.PrimaryScreen.Bounds.Width, 26, true);
        }

        private void SetFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Left = 0;
            this.Top = 0;
        }
    }
}