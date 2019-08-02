using System;
using System.Runtime.InteropServices;

namespace FFXIVAPP.Plugin.Parse.MouseHandler
{
    public class MouseMoveEvent: EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public abstract class MouseBase: IDisposable
    {
        public EventHandler<MouseMoveEvent> OnMouseMove = delegate { };

        private static MouseBase handler;

        public static MouseBase Handler
        {
            get
            {
                if (handler != null)
                    return handler;

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    return (handler = new MouseX11());
                }

                throw new Exception("Dont support OSPlatform");
            }
        }

        public MouseBase() {

        }

        public abstract void Dispose();
    }
}