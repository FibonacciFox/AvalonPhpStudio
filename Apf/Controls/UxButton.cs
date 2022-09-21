#nullable disable

using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls
{
    /// <summary>
    /// A button control.
    /// </summary>
    [PhpType]
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
