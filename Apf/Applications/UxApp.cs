#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;

namespace Apf.Applications;

public class UxApp
{
    public UxApp(Closure closure)
    {
        string[]? args;
       
        AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .UseFluentTheme(mode: FluentThemeMode.Light)
            .StartWithClassicDesktopLifetime(desktop =>
            {

                var closer = (Window) closure.__invoke().ToClass();
                
                desktop.MainWindow = closer;
                
            }, null);
    }
    
}