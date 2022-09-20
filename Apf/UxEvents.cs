using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Apf;



public class UxEvents
{
    private  IDictionary<string, EventHandler>  RoutedEvents;
    

    private  Control? _control;
    
    public UxEvents(Control? uxConrol)
    {
        RoutedEvents = new Dictionary<string, EventHandler>();
        _control = uxConrol;
    }


    public void Add( RoutedEvent arg, string key, Closure closure)
    {
        RoutedEvents[key] = (sender, args) => closure?.__invoke(PhpValue.FromClass(sender), PhpValue.FromClass(args));
        _control?.AddHandler(arg, RoutedEvents[key]);
    }
    
    public void Remove(string key)
    {
        //...
    }
    
}


