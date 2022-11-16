#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;

namespace Apf.Applications;

public class UXApplication
{
    public UXApplication(Closure closure, string[]? args = null)
    {
        
       
        AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .UseFluentTheme(mode: FluentThemeMode.Dark)
            .StartWithClassicDesktopLifetime(desktop =>
            {

                var closer = (Window) closure.__invoke().ToClass();
                
                desktop.MainWindow = closer;
                
            }, args);
    }
    
}