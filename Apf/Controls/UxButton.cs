#nullable disable

using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls
{
    /// <summary>
    /// Defines how a <see cref="UxButton"/> reacts to clicks.
    /// </summary>
    public enum ClickMode
    {
        /// <summary>
        /// The <see cref="UxButton.Click"/> event is raised when the pointer is released.
        /// </summary>
        Release,

        /// <summary>
        /// The <see cref="UxButton.Click"/> event is raised when the pointer is pressed.
        /// </summary>
        Press,
    }

    /// <summary>
    /// A button control.
    /// </summary>
    public class UxButton : Button, IStyleable
    {
        [PhpHidden] Type IStyleable.StyleKey => typeof(Button);

        /// <summary>
        /// События  <see cref="UxContentControl.Listener"/>
        /// </summary>
        public UxEvents Listener;

        public UxButton()
        {
            Listener = new UxEvents(this);
        }
    }
}
