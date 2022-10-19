using Avalonia;


namespace Apf.Applications.Windows;

public class UxAppBuilder
{
    
    public static void StartWithClassicDesktopLifetime(string[] args = null)
    {
       var app =  AppBuilder.Configure<UxApp>().UsePlatformDetect().LogToTrace();
       app.StartWithClassicDesktopLifetime(args);
    }
}