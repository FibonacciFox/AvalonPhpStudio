using Apf.Controls;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Pchp.Core;

namespace Apf.Applications.Windows
{
    public class UxApp : Application
    {
        
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = _uxWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
        
        private UxWindow _uxWindow;
        
    }

}
