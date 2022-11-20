#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;

namespace Apf.Platform;

public class UxApplication
{
    public UxApplication(Closure closure, string fluentThemeMode , string[]? args = null)
    {
        var builder =  AppBuilder.Configure<Application>();
            builder.UsePlatformDetect();
            
            switch (fluentThemeMode)
            {
                case "Dark":
                    builder.UseFluentTheme(mode: FluentThemeMode.Dark);
                    break;
                case "Light":
                    builder.UseFluentTheme(mode: FluentThemeMode.Light);
                    break;
                default:
                    builder.UseFluentTheme(mode: FluentThemeMode.Light);
                    break;
            }
            
            builder.StartWithClassicDesktopLifetime(desktop =>
            {
                desktop.MainWindow = (Window) closure.__invoke().ToClass();
            }, args );
    }
}