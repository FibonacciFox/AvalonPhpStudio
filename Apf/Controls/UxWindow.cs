using Apf.Interactivity;
using Avalonia.Controls;


namespace Apf.Controls;


/// <summary>
/// A top-level window.
/// </summary>
public class UxWindow : Window
{
    /// <summary>
    /// События  <see cref="UxContentControl.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxWindow()
    {
        Listener = new UxEvents(this);
    }
}