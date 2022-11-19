using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxRepeatButton : RepeatButton, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(RepeatButton);

}