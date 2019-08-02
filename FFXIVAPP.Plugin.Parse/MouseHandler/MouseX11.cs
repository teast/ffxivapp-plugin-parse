using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FFXIVAPP.Plugin.Parse.MouseHandler
{
    public class MouseX11: MouseBase
    {
        [DllImport("libX11.so")]
        private static extern IntPtr XOpenDisplay(IntPtr display);

        [DllImport("libX11.so")]
        private static extern int XCloseDisplay(IntPtr display);

        [DllImport("libX11.so")]
        private static extern int XScreenCount(IntPtr display);

        [DllImport("libX11.so")]
        private static extern ulong XRootWindow(IntPtr display, int screen_number);

        [DllImport("libX11.so")]
        private static extern bool XQueryPointer(IntPtr display, ulong window, out ulong root_return, out ulong child_return, out int root_x_return, out int root_y_return, out int win_x_return, out int win_y_return, out uint mask_return);

        private ulong[] windows;

        private bool running = false;

        private BackgroundWorker worker;
        public MouseX11()
        {
            var display = XOpenDisplay(IntPtr.Zero);
            if (display == IntPtr.Zero)
            {
                return;
            }

            var nrScreens = XScreenCount(display);
            if (nrScreens == 0)
            {
                return;
            }

            windows = new ulong[nrScreens];
            for(var i = 0; i < nrScreens; i++)
            {
                windows[i] = XRootWindow(display, i);
            }

            running = true;
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.ProgressChanged += (o, e) => {
                OnMouseMove?.Invoke(this, (e.UserState as MouseMoveEvent));
            };

            worker.DoWork += (o, e) => {
                int old_x = -1, old_y = -1;
                while(running) {
                    var result = false;
                    int root_x = 0, root_y = 0;
                    for(var i = 0; i < nrScreens; i++)
                    {
                        result = XQueryPointer(display, windows[i], out _, out _, out root_x, out root_y, out _, out _, out _);
                        if (result) {
                            break;
                        }
                    }

                    if (result)
                    {
                        if (old_x != root_x || old_y != root_y)
                        {
                            old_x = root_x;
                            old_y = root_y;
                            (o as BackgroundWorker)?.ReportProgress(0, new MouseMoveEvent { X = old_x, Y = old_y });
                        }
                    }
                }
            };

            worker.RunWorkerAsync();
        }

        public override void Dispose()
        {
            running = false;
            worker.CancelAsync();
            System.Threading.Thread.Sleep(100);
        }
    }
}