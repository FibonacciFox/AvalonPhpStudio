using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using Pchp.Core;

namespace Apf.Controls.Primitives
{
    /// <summary>
    /// Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states.
    /// </summary>
    public class UxToggleButton : ToggleButton , IStyleable
    {
        [PhpHidden] Type IStyleable.StyleKey => typeof(ToggleButton);
        
    }
}
