using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxTextBox : TextBox, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(TextBox);

    /// <summary>
    /// События  <see cref="UxTextBox.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxTextBox()
    {
        Listener = new UxEvents(this);
    }
}

