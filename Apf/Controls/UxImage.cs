using Apf.Interactivity;
using Avalonia.Controls;
namespace Apf.Controls;

/// <summary>
/// Represents a <see cref="UxImage"/> control.
/// </summary>
public class UxImage : Image
{
    
    /// <summary>
    /// События  <see cref="UxContentControl.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxImage()
    {
        Listener = new UxEvents(this);
    }
    
}