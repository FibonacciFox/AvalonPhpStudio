using Apf.Interactivity;
using Avalonia.Controls;

namespace Apf.Controls;

public class UxCanvas : Canvas
{
    /// <summary>
    /// События  <see cref="UxCanvas.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxCanvas()
    {
        Listener = new UxEvents(this);
    }
}