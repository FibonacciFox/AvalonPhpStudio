using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxNumericUpDown: NumericUpDown, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(NumericUpDown);

    /// <summary>
    /// События  <see cref="UxContentControl.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxNumericUpDown()
    {
        Listener = new UxEvents(this);
    }
}