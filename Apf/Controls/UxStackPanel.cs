using Apf.Interactivity;
using Avalonia.Controls;

namespace Apf.Controls;

public class UxStackPanel : StackPanel
{
    /// <summary>
    /// События  <see cref="UxStackPanel.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxStackPanel()
    {
        Listener = new UxEvents(this);
    }
}