using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace FFXIVAPP.Plugin.Parse.Helpers {
    /// <summary>
    /// Helper class to make a custom dragable window
    /// </summary>
    [Obsolete("Use PlatformImpl?.BeginMoveDrag() (see AvaloniaUI ControlCatalog sample for more info, search the code)")]
    public class CustomDragHelper
    {
        private bool inDrag = false;
        private bool wantToQuit = false;
        private Point anchorPoint;
        private Point origPoint;
        private Window form;

        /// <summary>
        /// Initialize a new instance of CustomDragHelper
        /// </summary>
        /// <param name="form">Window object to drag</param>
        /// <param name="titleBar">Element to trigger drag on</param>
        public CustomDragHelper(Window form, InputElement titleBar)
        {
            this.form = form;
            titleBar.PointerPressed += TitleBar_OnPointerPressed;
            titleBar.PointerReleased += TitleBar_OnPointerReleased;
            titleBar.PointerLeave += TitleBar_OnPointerLeave;
            MouseHandler.MouseBase.Handler.OnMouseMove += (o, e) => {
                if (this.inDrag)
                {
                    this.form.Position = new Point(this.origPoint.X - (this.anchorPoint.X - e.X), this.origPoint.Y - (this.anchorPoint.Y - e.Y));
                    if (this.wantToQuit && titleBar.IsPointerOver) {
                        this.wantToQuit = false;
                    }
                }
            };
        }

        private void TitleBar_OnPointerPressed(object sender, PointerPressedEventArgs e) {
            if (e.MouseButton != MouseButton.Left || (e.Device as IMouseDevice) == null)
                return;
            
            this.wantToQuit = false;
            this.inDrag = true;
            this.anchorPoint = (e.Device as IMouseDevice).Position;
            this.origPoint = this.form.Position;
            e.Handled = true;
        }

        private void TitleBar_OnPointerReleased(object sender, PointerReleasedEventArgs e) {
            this.inDrag = false;
        }

        private void TitleBar_OnPointerLeave(object sender, PointerEventArgs e) {
            // It takes a leave and a move outside to stop drag
            if (this.inDrag)
            {
                if (this.wantToQuit)
                {
                    this.inDrag = false;
                    this.wantToQuit = false;
                }
                else
                {
                    this.wantToQuit = true;
                }
            }
        }
    }
}