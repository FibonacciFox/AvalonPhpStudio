using Avalonia;
using System;

namespace AvaloniaApplication
{
    internal class Program
    {
        // Код инициализации. Не используйте кроме Avalonia, сторонние API.
        // Код, зависящий от SynchronizationContext, перед вызовом AppMain: вещи не инициализируются
        // еще и все может сломаться.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        // Конфигурация Avalonia, не удалять; также используется визуальным дизайнером.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
