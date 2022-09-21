#nullable disable

using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Styling;
using Avalonia.VisualTree;
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
        [PhpHidden]
        Type IStyleable.StyleKey => typeof(Button);

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
