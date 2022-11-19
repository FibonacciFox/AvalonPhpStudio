using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxProgressBar : ProgressBar, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(ProgressBar);
    
}