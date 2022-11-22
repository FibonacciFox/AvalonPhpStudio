using System.Collections.Specialized;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.LogicalTree;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Styling;

namespace Apf.ControlEventsExtensions;

public static class ApplicationEventsExtensions
{
    public static Application OnResourcesChanged(Application control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
    public static Application OnUrlsOpened(Application control, Action<UrlOpenedEventArgs> action) => 
        control._setEvent((EventHandler<UrlOpenedEventArgs>) ((_, args) => action(args)), h => control.UrlsOpened += h);
}
public static class AutoCompleteBoxEventsExtensions
{
    public static AutoCompleteBox OnTextChanged(AutoCompleteBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static AutoCompleteBox OnPopulating(AutoCompleteBox control, Action<PopulatingEventArgs> action) => 
        control._setEvent((EventHandler<PopulatingEventArgs>) ((_, args) => action(args)), h => control.Populating += h);
    public static AutoCompleteBox OnPopulated(AutoCompleteBox control, Action<PopulatedEventArgs> action) => 
        control._setEvent((EventHandler<PopulatedEventArgs>) ((_, args) => action(args)), h => control.Populated += h);
    public static AutoCompleteBox OnDropDownOpening(AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownOpening += h);
    public static AutoCompleteBox OnDropDownOpened(AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownOpened += h);
    public static AutoCompleteBox OnDropDownClosing(AutoCompleteBox control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.DropDownClosing += h);
    public static AutoCompleteBox OnDropDownClosed(AutoCompleteBox control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DropDownClosed += h);
    public static AutoCompleteBox OnSelectionChanged(AutoCompleteBox control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static class ButtonEventsExtensions
{
    public static Button OnClick(Button control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
}
public static class CalendarDatePickerEventsExtensions
{
    public static CalendarDatePicker OnCalendarClosed(CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarClosed += h);
    public static CalendarDatePicker OnCalendarOpened(CalendarDatePicker control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CalendarOpened += h);
    public static CalendarDatePicker OnDateValidationError(CalendarDatePicker control, Action<CalendarDatePickerDateValidationErrorEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>) ((_, args) => action(args)), h => control.DateValidationError += h);
    public static CalendarDatePicker OnSelectedDateChanged(CalendarDatePicker control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}
public static class CalendarEventsExtensions
{
    public static Calendar OnSelectedDatesChanged(Calendar control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDatesChanged += h);
    public static Calendar OnDisplayDateChanged(Calendar control, Action<CalendarDateChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarDateChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayDateChanged += h);
    public static Calendar OnDisplayModeChanged(Calendar control, Action<CalendarModeChangedEventArgs> action) => 
        control._setEvent((EventHandler<CalendarModeChangedEventArgs>) ((_, args) => action(args)), h => control.DisplayModeChanged += h);
}
public static class ContextMenuEventsExtensions
{
    public static ContextMenu OnContextMenuOpening(ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.ContextMenuOpening += h);
    public static ContextMenu OnContextMenuClosing(ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.ContextMenuClosing += h);
}
public static class ControlEventsExtensions
{
    public static Control OnContextRequested(Control control, Action<ContextRequestedEventArgs> action) => 
        control._setEvent((EventHandler<ContextRequestedEventArgs>) ((_, args) => action(args)), h => control.ContextRequested += h);
    public static Control OnLoaded(Control control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Loaded += h);
    public static Control OnUnloaded(Control control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unloaded += h);
}
public static class DatePickerEventsExtensions
{
    public static DatePicker OnSelectedDateChanged(DatePicker control, Action<DatePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<DatePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedDateChanged += h);
}
public static class TimePickerEventsExtensions
{
    public static TimePicker OnSelectedTimeChanged(TimePicker control, Action<TimePickerSelectedValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<TimePickerSelectedValueChangedEventArgs>) ((_, args) => action(args)), h => control.SelectedTimeChanged += h);
}
public static class MenuBaseEventsExtensions
{
    public static MenuBase OnMenuOpened(MenuBase control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.MenuOpened += h);
    public static MenuBase OnMenuClosed(MenuBase control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.MenuClosed += h);
}
public static class MenuItemEventsExtensions
{
    public static MenuItem OnClick(MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
    public static MenuItem OnPointerEnteredItem(MenuItem control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerEnteredItem += h);
    public static MenuItem OnPointerExitedItem(MenuItem control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerExitedItem += h);
    public static MenuItem OnSubmenuOpened(MenuItem control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.SubmenuOpened += h);
}
public static class NativeMenuEventsExtensions
{
    public static NativeMenu OnNeedsUpdate(NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.NeedsUpdate += h);
    public static NativeMenu OnOpening(NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Opening += h);
    public static NativeMenu OnClosed(NativeMenu control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
}
public static class NativeMenuItemEventsExtensions
{
    public static NativeMenuItem OnClick(NativeMenuItem control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Click += h);
}
public static class NumericUpDownEventsExtensions
{
    public static NumericUpDown OnSpinned(NumericUpDown control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spinned += h);
    public static NumericUpDown OnValueChanged(NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) => 
        control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>) ((_, args) => action(args)), h => control.ValueChanged += h);
}
public static class ItemsRepeaterEventsExtensions
{
    public static ItemsRepeater OnElementClearing(ItemsRepeater control, Action<ItemsRepeaterElementClearingEventArgs> action) => 
        control._setEvent((EventHandler<ItemsRepeaterElementClearingEventArgs>) ((_, args) => action(args)), h => control.ElementClearing += h);
    public static ItemsRepeater OnElementIndexChanged(ItemsRepeater control, Action<ItemsRepeaterElementIndexChangedEventArgs> action) => 
        control._setEvent((EventHandler<ItemsRepeaterElementIndexChangedEventArgs>) ((_, args) => action(args)), h => control.ElementIndexChanged += h);
    public static ItemsRepeater OnElementPrepared(ItemsRepeater control, Action<ItemsRepeaterElementPreparedEventArgs> action) => 
        control._setEvent((EventHandler<ItemsRepeaterElementPreparedEventArgs>) ((_, args) => action(args)), h => control.ElementPrepared += h);
}
// public static class RichTextBlockEventsExtensions
// {
//     public static RichTextBlock OnCopyingToClipboard(RichTextBlock control, Action<RoutedEventArgs> action) => 
//         control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
// }
public static class ScrollViewerEventsExtensions
{
    public static ScrollViewer OnScrollChanged(ScrollViewer control, Action<ScrollChangedEventArgs> action) => 
        control._setEvent((EventHandler<ScrollChangedEventArgs>) ((_, args) => action(args)), h => control.ScrollChanged += h);
}
public static class SpinnerEventsExtensions
{
    public static Spinner OnSpin(Spinner control, Action<SpinEventArgs> action) => 
        control._setEvent((EventHandler<SpinEventArgs>) ((_, args) => action(args)), h => control.Spin += h);
}
public static class SplitButtonEventsExtensions
{
    public static SplitButton OnClick(SplitButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Click += h);
}
public static class ToggleSplitButtonEventsExtensions
{
    public static ToggleSplitButton OnIsCheckedChanged(ToggleSplitButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.IsCheckedChanged += h);
}
public static class SplitViewEventsExtensions
{
    public static SplitView OnPaneClosed(SplitView control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.PaneClosed += h);
    public static SplitView OnPaneClosing(SplitView control, Action<SplitViewPaneClosingEventArgs> action) => 
        control._setEvent((EventHandler<SplitViewPaneClosingEventArgs>) ((_, args) => action(args)), h => control.PaneClosing += h);
    public static SplitView OnPaneOpened(SplitView control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.PaneOpened += h);
    public static SplitView OnPaneOpening(SplitView control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.PaneOpening += h);
}
public static class TextBoxEventsExtensions
{
    public static TextBox OnCopyingToClipboard(TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
    public static TextBox OnCuttingToClipboard(TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CuttingToClipboard += h);
    public static TextBox OnPastingFromClipboard(TextBox control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.PastingFromClipboard += h);
    public static TextBox OnTextChanged(TextBox control, Action<TextChangedEventArgs> action) => 
        control._setEvent((EventHandler<TextChangedEventArgs>) ((_, args) => action(args)), h => control.TextChanged += h);
    public static TextBox OnTextChanging(TextBox control, Action<TextChangingEventArgs> action) => 
        control._setEvent((EventHandler<TextChangingEventArgs>) ((_, args) => action(args)), h => control.TextChanging += h);
}
public static class TopLevelEventsExtensions
{
    public static TopLevel OnOpened(TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static TopLevel OnClosed(TopLevel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
}
public static class TrayIconEventsExtensions
{
    public static TrayIcon OnClicked(TrayIcon control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Clicked += h);
}
public static class TreeViewEventsExtensions
{
    public static TreeView OnSelectionChanged(TreeView control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static class WindowEventsExtensions
{
    public static Window OnClosing(Window control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
}
public static class WindowBaseEventsExtensions
{
    public static WindowBase OnActivated(WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Activated += h);
    public static WindowBase OnDeactivated(WindowBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Deactivated += h);
    public static WindowBase OnPositionChanged(WindowBase control, Action<PixelPointEventArgs> action) => 
        control._setEvent((EventHandler<PixelPointEventArgs>) ((_, args) => action(args)), h => control.PositionChanged += h);
}
public static class TextPresenterEventsExtensions
{
    public static TextPresenter OnCaretBoundsChanged(TextPresenter control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.CaretBoundsChanged += h);
}
public static class NotificationCardEventsExtensions
{
    public static NotificationCard OnNotificationClosed(NotificationCard control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.NotificationClosed += h);
}
public static class CalendarButtonEventsExtensions
{
    public static CalendarButton OnCalendarLeftMouseButtonDown(CalendarButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonDown += h);
    public static CalendarButton OnCalendarLeftMouseButtonUp(CalendarButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarLeftMouseButtonUp += h);
}
public static class CalendarDayButtonEventsExtensions
{
    public static CalendarDayButton OnCalendarDayButtonMouseDown(CalendarDayButton control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseDown += h);
    public static CalendarDayButton OnCalendarDayButtonMouseUp(CalendarDayButton control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.CalendarDayButtonMouseUp += h);
}
public static class DateTimePickerPanelEventsExtensions
{
    public static DateTimePickerPanel OnScrollInvalidated(DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ScrollInvalidated += h);
    public static DateTimePickerPanel OnSelectionChanged(DateTimePickerPanel control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.SelectionChanged += h);
}
public static class PickerPresenterBaseEventsExtensions
{
    public static PickerPresenterBase OnConfirmed(PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Confirmed += h);
    public static PickerPresenterBase OnDismissed(PickerPresenterBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Dismissed += h);
}
public static class FlyoutBaseEventsExtensions
{
    public static FlyoutBase OnClosed(FlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Closed += h);
    public static FlyoutBase OnClosing(FlyoutBase control, Action<CancelEventArgs> action) => 
        control._setEvent((EventHandler<CancelEventArgs>) ((_, args) => action(args)), h => control.Closing += h);
    public static FlyoutBase OnOpened(FlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
    public static FlyoutBase OnOpening(FlyoutBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opening += h);
}
public static class PopupEventsExtensions
{
    public static Popup OnClosed(Popup control, Action<EventArgs> action) => 
        control._setEvent((EventHandler<EventArgs>) ((_, args) => action(args)), h => control.Closed += h);
    public static Popup OnOpened(Popup control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Opened += h);
}
public static class ScrollBarEventsExtensions
{
    public static ScrollBar OnScroll(ScrollBar control, Action<ScrollEventArgs> action) => 
        control._setEvent((EventHandler<ScrollEventArgs>) ((_, args) => action(args)), h => control.Scroll += h);
}
public static class SelectingItemsControlEventsExtensions
{
    public static SelectingItemsControl OnSelectionChanged(SelectingItemsControl control, Action<SelectionChangedEventArgs> action) => 
        control._setEvent((EventHandler<SelectionChangedEventArgs>) ((_, args) => action(args)), h => control.SelectionChanged += h);
}
public static class TemplatedControlEventsExtensions
{
    public static TemplatedControl OnTemplateApplied(TemplatedControl control, Action<TemplateAppliedEventArgs> action) => 
        control._setEvent((EventHandler<TemplateAppliedEventArgs>) ((_, args) => action(args)), h => control.TemplateApplied += h);
}
public static class ThumbEventsExtensions
{
    public static Thumb OnDragStarted(Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragStarted += h);
    public static Thumb OnDragDelta(Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragDelta += h);
    public static Thumb OnDragCompleted(Thumb control, Action<VectorEventArgs> action) => 
        control._setEvent((EventHandler<VectorEventArgs>) ((_, args) => action(args)), h => control.DragCompleted += h);
}
public static class ToggleButtonEventsExtensions
{
    public static ToggleButton OnChecked(ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Checked += h);
    public static ToggleButton OnUnchecked(ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Unchecked += h);
    public static ToggleButton OnIndeterminate(ToggleButton control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.Indeterminate += h);
}
public static class AvaloniaObjectEventsExtensions
{
    public static AvaloniaObject OnPropertyChanged(AvaloniaObject control, Action<AvaloniaPropertyChangedEventArgs> action) => 
        control._setEvent((EventHandler<AvaloniaPropertyChangedEventArgs>) ((_, args) => action(args)), h => control.PropertyChanged += h);
}
public static class StyledElementEventsExtensions
{
    public static StyledElement OnAttachedToLogicalTree(StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToLogicalTree += h);
    public static StyledElement OnDetachedFromLogicalTree(StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromLogicalTree += h);
    public static StyledElement OnDataContextChanged(StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.DataContextChanged += h);
    public static StyledElement OnInitialized(StyledElement control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Initialized += h);
    public static StyledElement OnResourcesChanged(StyledElement control, Action<ResourcesChangedEventArgs> action) => 
        control._setEvent((EventHandler<ResourcesChangedEventArgs>) ((_, args) => action(args)), h => control.ResourcesChanged += h);
}
public static class VisualEventsExtensions
{
    public static Visual OnAttachedToVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.AttachedToVisualTree += h);
    public static Visual OnDetachedFromVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) => 
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>) ((_, args) => action(args)), h => control.DetachedFromVisualTree += h);
}
public static class StyleBaseEventsExtensions
{
    public static StyleBase OnOwnerChanged(StyleBase control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}
public static class StylesEventsExtensions
{
    public static Styles OnCollectionChanged(Styles control, Action action) => 
        control._setEvent((NotifyCollectionChangedEventHandler) ((_, args) => action()), h => control.CollectionChanged += h);
    public static Styles OnOwnerChanged(Styles control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.OwnerChanged += h);
}
public static class AttachedLayoutEventsExtensions
{
    public static AttachedLayout OnMeasureInvalidated(AttachedLayout control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.MeasureInvalidated += h);
    public static AttachedLayout OnArrangeInvalidated(AttachedLayout control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.ArrangeInvalidated += h);
}
public static class LayoutableEventsExtensions
{
    public static Layoutable OnEffectiveViewportChanged(Layoutable control, Action<EffectiveViewportChangedEventArgs> action) => 
        control._setEvent((EventHandler<EffectiveViewportChangedEventArgs>) ((_, args) => action(args)), h => control.EffectiveViewportChanged += h);
    public static Layoutable OnLayoutUpdated(Layoutable control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.LayoutUpdated += h);
}
public static class InputElementEventsExtensions
{
    public static InputElement OnGotFocus(InputElement control, Action<GotFocusEventArgs> action) => 
        control._setEvent((EventHandler<GotFocusEventArgs>) ((_, args) => action(args)), h => control.GotFocus += h);
    public static InputElement OnLostFocus(InputElement control, Action<RoutedEventArgs> action) => 
        control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.LostFocus += h);
    public static InputElement OnKeyDown(InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyDown += h);
    public static InputElement OnKeyUp(InputElement control, Action<KeyEventArgs> action) => 
        control._setEvent((EventHandler<KeyEventArgs>) ((_, args) => action(args)), h => control.KeyUp += h);
    public static InputElement OnTextInput(InputElement control, Action<TextInputEventArgs> action) => 
        control._setEvent((EventHandler<TextInputEventArgs>) ((_, args) => action(args)), h => control.TextInput += h);
    public static InputElement OnTextInputMethodClientRequested(InputElement control, Action<TextInputMethodClientRequestedEventArgs> action) => 
        control._setEvent((EventHandler<TextInputMethodClientRequestedEventArgs>) ((_, args) => action(args)), h => control.TextInputMethodClientRequested += h);
    public static InputElement OnPointerEntered(InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerEntered += h);
    public static InputElement OnPointerExited(InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerExited += h);
    public static InputElement OnPointerMoved(InputElement control, Action<PointerEventArgs> action) => 
        control._setEvent((EventHandler<PointerEventArgs>) ((_, args) => action(args)), h => control.PointerMoved += h);
    public static InputElement OnPointerPressed(InputElement control, Action<PointerPressedEventArgs> action) => 
        control._setEvent((EventHandler<PointerPressedEventArgs>) ((_, args) => action(args)), h => control.PointerPressed += h);
    public static InputElement OnPointerReleased(InputElement control, Action<PointerReleasedEventArgs> action) => 
        control._setEvent((EventHandler<PointerReleasedEventArgs>) ((_, args) => action(args)), h => control.PointerReleased += h);
    public static InputElement OnPointerCaptureLost(InputElement control, Action<PointerCaptureLostEventArgs> action) => 
        control._setEvent((EventHandler<PointerCaptureLostEventArgs>) ((_, args) => action(args)), h => control.PointerCaptureLost += h);
    public static InputElement OnPointerWheelChanged(InputElement control, Action<PointerWheelEventArgs> action) => 
        control._setEvent((EventHandler<PointerWheelEventArgs>) ((_, args) => action(args)), h => control.PointerWheelChanged += h);
    public static InputElement OnTapped(InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.Tapped += h);
    public static InputElement OnDoubleTapped(InputElement control, Action<TappedEventArgs> action) => 
        control._setEvent((EventHandler<TappedEventArgs>) ((_, args) => action(args)), h => control.DoubleTapped += h);
}
public static class BrushEventsExtensions
{
    public static Brush OnInvalidated(Brush control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static class DashStyleEventsExtensions
{
    public static DashStyle OnInvalidated(DashStyle control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static class DrawingImageEventsExtensions
{
    public static DrawingImage OnInvalidated(DrawingImage control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static class ExperimentalAcrylicMaterialEventsExtensions
{
    public static ExperimentalAcrylicMaterial OnInvalidated(ExperimentalAcrylicMaterial control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static class GeometryEventsExtensions
{
    public static Geometry OnChanged(Geometry control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Changed += h);
}
public static class PenEventsExtensions
{
    public static Pen OnInvalidated(Pen control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}
public static class TransformEventsExtensions
{
    public static Transform OnChanged(Transform control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Changed += h);
}
public static class CroppedBitmapEventsExtensions
{
    public static CroppedBitmap OnInvalidated(CroppedBitmap control, Action action) => 
        control._setEvent((EventHandler) ((_, args) => action()), h => control.Invalidated += h);
}

