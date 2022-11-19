using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxTabControl : TabControl, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(TabControl);

}