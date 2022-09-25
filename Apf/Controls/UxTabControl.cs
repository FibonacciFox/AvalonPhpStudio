using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxTabControl : TabControl, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(TabControl);
    
    /// <summary>
    /// События  <see cref="UxTabControl.Listener"/>
    /// </summary>
    public UxEvents Listener;
    
    public UxTabControl()
    {
        Listener = new UxEvents(this);
    }
    
}