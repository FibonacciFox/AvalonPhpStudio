using System.Collections;
using Apf.Interactivity;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

public class UxListBox : ListBox, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(ListBox);
        
    public UxEvents Listener;
    
    public UxListBox()
    {
        Listener = new UxEvents(this);
    }
    
}