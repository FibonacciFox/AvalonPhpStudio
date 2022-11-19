using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxTextBox : TextBox, IStyleable
{ 
    [PhpHidden] Type IStyleable.StyleKey => typeof(TextBox);
    
}

