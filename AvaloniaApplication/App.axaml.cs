using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using App;



namespace AvaloniaApplication
{
    public partial class App : Application
    {
        public override void Initialize()
        {
           
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                
                var mainwindow = new MainWindow();
              
                // set source name for the new theme
              
                desktop.MainWindow = mainwindow; // new Test();
                
            
            }

            base.OnFrameworkInitializationCompleted();
        }

    }

}
