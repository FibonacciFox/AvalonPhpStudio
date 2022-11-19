using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxListBox : ListBox, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(ListBox);
    
}