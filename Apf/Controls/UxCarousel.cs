using Apf.Interactivity;
using Avalonia.Controls;

namespace Apf.Controls;

public class UxCarousel : Carousel
{
    /// <summary>
    /// События  <see cref="UxCarousel.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxCarousel()
    {
        Listener = new UxEvents(this);
    }
}