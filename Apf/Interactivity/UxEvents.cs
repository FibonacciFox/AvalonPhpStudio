using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Apf.Interactivity;


public class UxEvents
{
    private readonly IDictionary<PhpValue, EventHandler>  _dictionaryHandlers;

    public IDictionary<PhpValue, EventHandler> Dictionary
    {
        get =>  _dictionaryHandlers;
    }

    private  Control? _control;
    
    public UxEvents(Control? uxConrol)
    {
        _dictionaryHandlers = new Dictionary<PhpValue, EventHandler>();
        _control = uxConrol;
    }


    public void Add( RoutedEvent arg, PhpValue key, Closure closure)
    {
        _dictionaryHandlers[key] = (sender, args) => closure?.__invoke(PhpValue.FromClass(sender), PhpValue.FromClass(args));
        _control?.AddHandler(arg, _dictionaryHandlers[key]);
    }
    
    public void Remove(RoutedEvent arg, PhpValue key)
    {
        _control?.RemoveHandler(arg, _dictionaryHandlers[key]);
        _dictionaryHandlers.Remove(key);
    }
    
}


