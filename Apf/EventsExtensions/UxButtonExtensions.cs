using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;

namespace Apf.EventsExtensions;

public class UxButtonExtensions
{
public static Button ClickMode(Button control, IBinding binding)
   => control._set(() => control[!Button.ClickModeProperty] = binding);

public static Button ClickMode(Button control, ClickMode value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);

public static Button ClickMode<TValue>(Button control, TValue value, FuncValueConverter<TValue, ClickMode> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = (ClickMode)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button Command(Button control, IBinding binding)
   => control._set(() => control[!Button.CommandProperty] = binding);

public static Button Command(Button control, ICommand value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);

public static Button Command<TValue>(Button control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = (ICommand)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button HotKey(Button control, IBinding binding)
   => control._set(() => control[!Button.HotKeyProperty] = binding);

public static Button HotKey(Button control, KeyGesture value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);

public static Button HotKey<TValue>(Button control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = (KeyGesture)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button CommandParameter(Button control, IBinding binding)
   => control._set(() => control[!Button.CommandParameterProperty] = binding);

public static Button CommandParameter(Button control, Object value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);

public static Button CommandParameter<TValue>(Button control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = (Object)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button IsDefault(Button control, IBinding binding)
   => control._set(() => control[!Button.IsDefaultProperty] = binding);

public static Button IsDefault(Button control, Boolean value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);

public static Button IsDefault<TValue>(Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = (Boolean)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button IsCancel(Button control, IBinding binding)
   => control._set(() => control[!Button.IsCancelProperty] = binding);

public static Button IsCancel(Button control, Boolean value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);

public static Button IsCancel<TValue>(Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = (Boolean)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);

public static Button Flyout(Button control, IBinding binding)
   => control._set(() => control[!Button.FlyoutProperty] = binding);

public static Button Flyout(Button control, FlyoutBase value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);

public static Button Flyout<TValue>(Button control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = (FlyoutBase)converter.Convert(value,typeof(TValue), null, default), bindingMode, converter, bindingSource);
}