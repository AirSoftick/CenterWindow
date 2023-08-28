using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CenterWindow
{
    public partial class WC : Form
    {
        private int shiftCount = 0;
        private Thread thread;
        private int savedWidth;
        private int savedHeight;
        private bool isRunning = false;

        public WC()
        {
            InitializeComponent();

            string[] positions = { "Центр", "Центр верхний", "Центр нижний", "Правый верхний угол", "Правый нижний угол", "Левый верхний угол", "Левый нижний угол" };
            comboBoxPosition.Items.AddRange(positions);

            comboBoxPosition.SelectedIndex = 0;

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Открыть", TrayOpen_Click);
            trayMenu.MenuItems.Add("Выход", TrayExit_Click);

            trayIcon = new NotifyIcon();
            trayIcon.Icon = Properties.Resources.IconProgramm;
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            trayIcon.Visible = false;
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                bttStart.Text = "ОСТАНОВИТЬ";

                thread = new Thread(WaitForShiftKeyPress);
                thread.Start();
            }
            else
            {
                isRunning = false;
                bttStart.Text = "ЗАПУСТИТЬ";
            }
        }

        private void WaitForShiftKeyPress()
        {
            while (isRunning && shiftCount < 3)
            {
                if (IsShiftKeyPressed())
                {
                    shiftCount++;
                }
                else
                {
                    shiftCount = 0;
                }

                Thread.Sleep(100);
            }

            if (isRunning)
            {
                Invoke(new Action(() =>
                {
                    AlignWindow();
                }));

                shiftCount = 0;

                WaitForShiftKeyPress();
            }
        }

        private bool IsShiftKeyPressed()
        {
            short shiftState = GetKeyState(VirtualKeyStates.VK_SHIFT);
            return (shiftState & 0x8000) != 0;
        }

        private void AlignWindow()
        {
            IntPtr activeWindowHandle = GetForegroundWindow();

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            RECT windowRect;
            GetWindowRect(activeWindowHandle, out windowRect);
            int windowWidth = windowRect.right - windowRect.left;
            int windowHeight = windowRect.bottom - windowRect.top;

            savedWidth = windowWidth;
            savedHeight = windowHeight;

            string selectedPosition = comboBoxPosition.SelectedItem.ToString();

            switch (selectedPosition)
            {
                case "Центр":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, (screenWidth / 2) - (windowWidth / 2), (screenHeight / 2) - (windowHeight / 2), windowWidth, windowHeight, 0);
                    break;
                case "Центр верхний":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, (screenWidth / 2) - (windowWidth / 2), 0, windowWidth, windowHeight, 0);
                    break;
                case "Центр нижний":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, (screenWidth / 2) - (windowWidth / 2), screenHeight - windowHeight, windowWidth, windowHeight, 0);
                    break;
                case "Правый верхний угол":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, screenWidth - windowWidth, 0, windowWidth, windowHeight, 0);
                    break;
                case "Правый нижний угол":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, screenWidth - windowWidth, screenHeight - windowHeight, windowWidth, windowHeight, 0);
                    break;
                case "Левый верхний угол":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, 0, 0, windowWidth, windowHeight, 0);
                    break;
                case "Левый нижний угол":
                    SetWindowPos(activeWindowHandle, IntPtr.Zero, 0, screenHeight - windowHeight, windowWidth, windowHeight, 0);
                    break;
            }
        }

        [DllImport("user32.dll")]
        private static extern short GetKeyState(VirtualKeyStates virtualKeyCode);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        private enum VirtualKeyStates : int
        {
            VK_SHIFT = 0x10,
        }

        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        private void bttClose_Click(object sender, EventArgs e)
        {

        }

        private void ShowForm()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }

        private void HideForm()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void WC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideForm();
                trayIcon.Visible = true;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void TrayOpen_Click(object sender, EventArgs e)
        {
            ShowForm();
            trayIcon.Visible = false;
        }

        private void TrayExit_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
