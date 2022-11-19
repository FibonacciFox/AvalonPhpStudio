using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxNumericUpDown: NumericUpDown, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(NumericUpDown);
    
}