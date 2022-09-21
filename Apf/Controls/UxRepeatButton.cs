using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxRepeatButton : RepeatButton, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(Button);
    
    /// <summary>
    /// События  <see cref="UxContentControl.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxRepeatButton()
    {
        Listener = new UxEvents(this);
    }
}