using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;

namespace Apf.Applications;

public class UxInputElementEventsExtensions
{
    private InputElement _control;
    
    public UxInputElementEventsExtensions(InputElement control)
    {
        _control = control;
    }
    
    public InputElement OnGotFocus( Action<GotFocusEventArgs> action) => 
        _control._setEvent((EventHandler<GotFocusEventArgs>) ((_, args) => action(args)), h => _control.GotFocus += h);
    
    public InputElement OnLostFocus(Action<RoutedEventArgs> action) => 
        _control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => _control.LostFocus += h);
    
    public InputElement OnKeyDown(Action<KeyEventArgs> action) => 
        _control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => _control.KeyDown += h);
    
    public InputElement OnKeyUp(Action<KeyEventArgs> action) => 
        _control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => _control.KeyUp += h);
    
    public InputElement OnTextInput(Action<TextInputEventArgs> action) => 
        _control._setEvent((EventHandler<TextInputEventArgs>) ((_, args) => action(args)), h => _control.TextInput += h);
    
    public InputElement OnTextInputMethodClientRequested(Action<TextInputMethodClientRequestedEventArgs> action) => 
        _control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) ((_, args) => action(args)), h => _control.TextInputMethodClientRequested += h);
    
    public InputElement OnPointerEntered(Action<PointerEventArgs> action) => 
        _control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => _control.PointerEntered += h);
    
    public InputElement OnPointerExited(Action<PointerEventArgs> action) => 
        _control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => _control.PointerExited += h);
    
    public InputElement OnPointerMoved(Action<PointerEventArgs> action) => 
        _control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => _control.PointerMoved += h);
    
    public InputElement OnPointerPressed(Action<PointerPressedEventArgs> action) => 
        _control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => _control.PointerPressed += h);
    
    public InputElement OnPointerReleased(Action<PointerReleasedEventArgs> action) => 
        _control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => _control.PointerReleased += h);
    
    public InputElement OnPointerCaptureLost(Action<PointerCaptureLostEventArgs> action) => 
        _control._setEvent((EventHandler<PointerCaptureLostEventArgs>) ((_, args) => action(args)), h => _control.PointerCaptureLost += h);
    
    public  InputElement OnPointerWheelChanged(Action<PointerWheelEventArgs> action) => 
        _control._setEvent((EventHandler<PointerWheelEventArgs>) ((_, args) => action(args)), h => _control.PointerWheelChanged += h);
    
    public InputElement OnTapped(Action<TappedEventArgs> action) => 
        _control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => _control.Tapped += h);
   
    public InputElement OnDoubleTapped(Action<TappedEventArgs> action) => 
        _control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => _control.DoubleTapped += h);
}
