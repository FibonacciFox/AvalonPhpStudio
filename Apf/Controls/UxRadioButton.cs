using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxRadioButton : RadioButton, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(RadioButton);
    
}