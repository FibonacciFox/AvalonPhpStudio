#nullable disable

using Apf.Applications;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls
{
    /// <summary>
    /// A button control.
    /// </summary>
    [PhpType]
    public class UxButton : Button, IStyleable
    {
        [PhpHidden] public Type StyleKey => typeof(Button);
        public  UxButton OnClick(Action<RoutedEventArgs> action) => 
            this._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => this.Click += h);
    }
}
