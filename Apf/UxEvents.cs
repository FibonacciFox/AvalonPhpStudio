using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Apf;



public class UxEvents
{
    private readonly IDictionary<PhpValue, EventHandler>  _routedEvents;
    

    private  Control? _control;
    
    public UxEvents(Control? uxConrol)
    {
        _routedEvents = new Dictionary<PhpValue, EventHandler>();
        _control = uxConrol;
    }


    public void Add( RoutedEvent arg, PhpValue key, Closure closure)
    {
        _routedEvents[key] = (sender, args) => closure?.__invoke(PhpValue.FromClass(sender), PhpValue.FromClass(args));
        _control?.AddHandler(arg, _routedEvents[key]);
    }
    
    public void Remove(RoutedEvent arg, PhpValue key)
    {
        _control?.RemoveHandler(arg, _routedEvents[key]);
        _routedEvents.Remove(key);
    }
    
}


