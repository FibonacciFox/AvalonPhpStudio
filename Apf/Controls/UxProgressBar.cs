using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxProgressBar : ProgressBar, IStyleable
{
    /// <summary>
    /// События  <see cref="UxProgressBar.Listener"/>
    /// </summary>
    [PhpHidden] Type IStyleable.StyleKey => typeof(ProgressBar);
        
    public UxEvents Listener;
    
    public UxProgressBar()
    {
        Listener = new UxEvents(this);
    }
}