using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxCalendar : Calendar , IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(Calendar);
        
    public UxEvents Listener;
    
    public UxCalendar()
    {
        Listener = new UxEvents(this);
    }
}