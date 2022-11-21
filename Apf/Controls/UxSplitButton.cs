using Apf.EventsExtensions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Apf.Controls;

[PhpType]
public class UxSplitButton : SplitButton
{
    [PhpHidden] public Type StyleKey => typeof(SplitButton);
    
    public UxSplitButton OnClick(Action<RoutedEventArgs> action) =>
        this._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => this.Click += h);
}