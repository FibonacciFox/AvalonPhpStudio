using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;

namespace Apf.EventsExtensions;

public class UxInputElementEvents
{
    
    public InputElement OnGotFocus(InputElement control, Action<GotFocusEventArgs> action) => 
        control._setEvent((EventHandler<GotFocusEventArgs>) ((_, args) => action(args)), h => control.GotFocus += h);
    
    public InputElement OnLostFocus(InputElement control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.LostFocus += h);
    
    public InputElement OnKeyDown(InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyDown += h);
    
    public InputElement OnKeyUp(InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyUp += h);
    
    public InputElement OnTextInput(InputElement control, Action<TextInputEventArgs> action) => 
        control._setEvent((EventHandler<TextInputEventArgs>) ((_, args) => action(args)), h => control.TextInput += h);
    
    public InputElement OnTextInputMethodClientRequested(InputElement control, Action<TextInputMethodClientRequestedEventArgs> action) => 
        control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) ((_, args) => action(args)), h => control.TextInputMethodClientRequested += h);
    
    public static InputElement OnPointerEntered(InputElement control,Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerEntered += h);
    
    public InputElement OnPointerExited(InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerExited += h);
    
    public InputElement OnPointerMoved(InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerMoved += h);
    
    public InputElement OnPointerPressed(InputElement control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.PointerPressed += h);
    
    public InputElement OnPointerReleased(InputElement control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.PointerReleased += h);
    
    public InputElement OnPointerCaptureLost(InputElement control, Action<PointerCaptureLostEventArgs> action) => 
        control._setEvent((EventHandler<PointerCaptureLostEventArgs>) ((_, args) => action(args)), h => control.PointerCaptureLost += h);
    
    public  InputElement OnPointerWheelChanged(InputElement control, Action<PointerWheelEventArgs> action) => 
        control._setEvent((EventHandler<PointerWheelEventArgs>) ((_, args) => action(args)), h => control.PointerWheelChanged += h);
    
    public InputElement OnTapped(InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.Tapped += h);
   
    public InputElement OnDoubleTapped(InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.DoubleTapped += h);
}
