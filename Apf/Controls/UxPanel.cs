using Apf.Interactivity;
using Avalonia.Controls;

namespace Apf.Controls;

public class UxPanel : Panel 
{
    
    /// <summary>
    /// События  <see cref="UxContentControl.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxPanel()
    {
        Listener = new UxEvents(this);
    }
    
}