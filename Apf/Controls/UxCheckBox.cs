using Apf.Controls.Primitives;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls;

/// <summary>
/// A check box control.
/// </summary>
public class UxCheckBox : UxToggleButton, IStyleable
{
    [PhpHidden]
    Type IStyleable.StyleKey => typeof(CheckBox);

}