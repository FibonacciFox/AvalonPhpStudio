using Apf.EventsExtensions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Apf.Controls;

public class UxToggleSplitButton : ToggleSplitButton
{
    [PhpHidden] public Type StyleKey => typeof(ToggleSplitButton);
    
    public UxToggleSplitButton OnClick(Action<RoutedEventArgs> action) =>
        this._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => this.Click += h);
}