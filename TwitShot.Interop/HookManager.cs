using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TwitShot.Interop
{
    public class HookManager
    {
        private static IntPtr _hookID = IntPtr.Zero;

        public static bool IsPressed(Keys check)
        {
            return ((Control.ModifierKeys & check) == check);
        }

        public IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WindowsNative.WM_KEYUP)
            {
                OnKeyup((Keys)Marshal.ReadInt32(lParam));
            }
            return WindowsNative.CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public virtual void OnKeyup(Keys keys)
        {
        }

        public IntPtr SetHook(Func<int, IntPtr, IntPtr, IntPtr> proc)
        {
            using (var curProcess = Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return WindowsNative.SetWindowsHookEx(WindowsNative.WH_KEYBOARD_LL, proc,
                    WindowsNative.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public void ActivateHooks()
        {
            _hookID = SetHook(HookCallback);
        }

        public void DeactivateHooks()
        {
            WindowsNative.UnhookWindowsHookEx(_hookID);
        }

    }
}