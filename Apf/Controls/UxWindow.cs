using System.ComponentModel;
using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;


namespace Apf.Controls;


/// <summary>
/// A top-level window.
/// </summary>
public class UxWindow : Window
{
    /// <summary>
    /// События  <see cref="UxWindow.Listener"/>
    /// </summary>
    public UxEvents Listener;
    

    public UxWindow()
    {
        Listener = new UxEvents(this);
    }
    
    public void OnClosed(PhpValue key, Closure closure)
    {
        Listener.Dictionary[key] = (sender, args) => closure?.__invoke(PhpValue.FromClass(sender), PhpValue.FromClass(args));
        Closed += Listener.Dictionary[key];
    }
    
    public void OnClosing(PhpValue key, Closure closure)
    {
        Listener.Dictionary[key] = (sender, args) => closure?.__invoke(PhpValue.FromClass(sender), PhpValue.FromClass(args));
       // Closing += Listener.Dictionary[key];
    }
}