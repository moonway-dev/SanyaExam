using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp.Components
{
    public class KeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private IntPtr hookId = IntPtr.Zero;
        private LowLevelKeyboardProc keyboardProc;

        public event Action<Keys, bool> KeyStateChanged;

        private bool isEnabled = false;

        public KeyboardHook()
        {
            InitializeGlobalKeyboardHook();
        }

        public void Start()
        {
            isEnabled = true;
        }

        public void Stop()
        {
            isEnabled = false;
        }

        public bool CheckState()
        {
            return isEnabled;
        }

        private void InitializeGlobalKeyboardHook()
        {
            keyboardProc = HookCallback;
            hookId = SetHook(keyboardProc);
            AppDomain.CurrentDomain.ProcessExit += (sender, e) => Unhook();
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_KEYUP) && isEnabled)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                bool keyDown = wParam == (IntPtr)WM_KEYDOWN;
                KeyStateChanged?.Invoke(key, keyDown);
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private void Unhook()
        {
            UnhookWindowsHookEx(hookId);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
