using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Input;
using log4net;

namespace TwitShot.Interop
{
    public class KeyboardHook : WindowsNativeBase, IDisposable
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(KeyboardHook));

        private readonly LowLevelKeyboardProc _keyboardProc;
        private IntPtr _hookId = IntPtr.Zero;

        public Key SelectedKey { get; set; }

        public KeyboardHook()
        {
            _keyboardProc = HookCallback;
            _hookId = SetHook(_keyboardProc);
        }

        public void Dispose()
        {
            UnhookWindowsHookEx(_hookId);
        }

        public event EventHandler KeyCombinationPressed;

        public void OnKeyCombinationPressed(EventArgs e)
        {
            EventHandler handler = KeyCombinationPressed;
            if (handler != null) handler(null, e);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                                        GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                var keyPressed = KeyInterop.KeyFromVirtualKey(vkCode);

                if (Logger.IsInfoEnabled)
                {
                    Logger.InfoFormat("Key pressed: {0}", keyPressed);
                }

                if (keyPressed == SelectedKey && Keyboard.Modifiers == ModifierKeys.Control)
                {
                    if (Logger.IsInfoEnabled)
                    {
                        Logger.Info("Triggering Keyboard Hook");
                    }
                    OnKeyCombinationPressed(new EventArgs());
                }
            }

            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }
    }
}
