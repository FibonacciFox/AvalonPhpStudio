<?php
namespace Extensions;

use Apf\ControlEventsExtensions\ApplicationEventsExtensions;
use Apf\ControlEventsExtensions\AutoCompleteBoxEventsExtensions;
use Apf\ControlEventsExtensions\CalendarDatePickerEventsExtensions;
use Apf\ControlEventsExtensions\CalendarEventsExtensions;
use Apf\ControlEventsExtensions\ContextMenuEventsExtensions;
use Apf\ControlEventsExtensions\ControlEventsExtensions;


trait UxApplicationEventsExtensions
{
    public function OnApplicationResourcesChanged (Closure $callback) {
        return ApplicationEventsExtensions::OnResourcesChanged($this, $callback);
    }

    public function OnApplicationUrlsOpened (Closure $callback) {
        return ApplicationEventsExtensions::OnUrlsOpened($this, $callback);
    }
}

trait UxAutoCompleteBoxEventsExtensions
{

    public function OnAutoCompleteBoxTextChanged (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnTextChanged($this, $callback);
    }

    public function OnAutoCompleteBoxPopulating (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnPopulating($this, $callback);
    }

    public function OnAutoCompleteBoxPopulated (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnPopulated($this, $callback);
    }

    public function OnAutoCompleteBoxDropDownOpening (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnDropDownOpening($this, $callback);
    }

    public function OnAutoCompleteBoxDropDownOpened (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnDropDownOpened($this, $callback);
    }

    public function OnAutoCompleteBoxDropDownClosing (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnDropDownClosing($this, $callback);
    }

    public function OnAutoCompleteBoxDropDownClosed (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnDropDownClosed($this, $callback);
    }

    public function OnAutoCompleteBoxSelectionChanged (Closure $callback) {
        return AutoCompleteBoxEventsExtensions::OnSelectionChanged($this, $callback);
    }
}

trait UxCalendarDatePickerEventsExtensions
{

    public function OnCalendarDatePickerCalendarClosed (Closure $callback) {
        return CalendarDatePickerEventsExtensions::OnCalendarClosed($this, $callback);
    }

    public function OnCalendarDatePickerCalendarOpened (Closure $callback) {
        return CalendarDatePickerEventsExtensions::OnCalendarOpened($this, $callback);
    }

    public function OnCalendarDatePickerDateValidationError (Closure $callback) {
        return CalendarDatePickerEventsExtensions::OnDateValidationError($this, $callback);
    }

    public function OnCalendarDatePickerSelectedDateChanged (Closure $callback) {
        return CalendarDatePickerEventsExtensions::OnSelectedDateChanged($this, $callback);
    }
}

trait UxCalendarEventsExtensions
{

    public function OnCalendarSelectedDatesChanged (Closure $callback) {
        return CalendarEventsExtensions::OnSelectedDatesChanged($this, $callback);
    }

    public function OnCalendarDisplayDateChanged (Closure $callback) {
        return CalendarEventsExtensions::OnDisplayDateChanged($this, $callback);
    }

    public function OnCalendarDisplayModeChanged (Closure $callback) {
        return CalendarEventsExtensions::OnDisplayModeChanged($this, $callback);
    }
}

trait UxContextMenuEventsExtensions
{

    public function OnContextMenuContextMenuOpening (Closure $callback) {
        return ContextMenuEventsExtensions::OnContextMenuOpening($this, $callback);
    }

    public function OnContextMenuContextMenuClosing (Closure $callback) {
        return ContextMenuEventsExtensions::OnContextMenuClosing($this, $callback);
    }
}

trait UxControlEventsExtensions
{

    public function OnControlContextRequested (Closure $callback) {
        return ControlEventsExtensions::OnContextRequested($this, $callback);
    }

    public function OnControlLoaded (Closure $callback) {
        return ControlEventsExtensions::OnLoaded($this, $callback);
    }

    public function OnControlUnloaded (Closure $callback) {
        return ControlEventsExtensions::OnUnloaded($this, $callback);
    }
}

trait UxDatePickerEventsExtensions
{

    public function OnDatePickerSelectedDateChanged (Closure $callback) {
        return DatePickerEventsExtensions::OnSelectedDateChanged($this, $callback);
    }
}

trait UxTimePickerEventsExtensions
{

    public function OnTimePickerSelectedTimeChanged (Closure $callback) {
        return TimePickerEventsExtensions::OnSelectedTimeChanged($this, $callback);
    }
}

trait UxMenuBaseEventsExtensions
{

    public function OnMenuBaseMenuOpened (Closure $callback) {
        return MenuBaseEventsExtensions::OnMenuOpened($this, $callback);
    }

    public function OnMenuBaseMenuClosed (Closure $callback) {
        return MenuBaseEventsExtensions::OnMenuClosed($this, $callback);
    }
}

trait UxMenuItemEventsExtensions
{

    public function OnMenuItemClick (Closure $callback) {
        return MenuItemEventsExtensions::OnClick($this, $callback);
    }

    public function OnMenuItemPointerEnteredItem (Closure $callback) {
        return MenuItemEventsExtensions::OnPointerEnteredItem($this, $callback);
    }

    public function OnMenuItemPointerExitedItem (Closure $callback) {
        return MenuItemEventsExtensions::OnPointerExitedItem($this, $callback);
    }

    public function OnMenuItemSubmenuOpened (Closure $callback) {
        return MenuItemEventsExtensions::OnSubmenuOpened($this, $callback);
    }
}

trait UxNativeMenuEventsExtensions
{

    public function OnNativeMenuNeedsUpdate (Closure $callback) {
        return NativeMenuEventsExtensions::OnNeedsUpdate($this, $callback);
    }

    public function OnNativeMenuOpening (Closure $callback) {
        return NativeMenuEventsExtensions::OnOpening($this, $callback);
    }

    public function OnNativeMenuClosed (Closure $callback) {
        return NativeMenuEventsExtensions::OnClosed($this, $callback);
    }
}

trait UxNativeMenuItemEventsExtensions
{

    public function OnNativeMenuItemClick (Closure $callback) {
        return NativeMenuItemEventsExtensions::OnClick($this, $callback);
    }
}

trait UxNumericUpDownEventsExtensions
{

    public function OnNumericUpDownSpinned (Closure $callback) {
        return NumericUpDownEventsExtensions::OnSpinned($this, $callback);
    }

    public function OnNumericUpDownValueChanged (Closure $callback) {
        return NumericUpDownEventsExtensions::OnValueChanged($this, $callback);
    }
}

trait UxItemsRepeaterEventsExtensions
{

    public function OnItemsRepeaterElementClearing (Closure $callback) {
        return ItemsRepeaterEventsExtensions::OnElementClearing($this, $callback);
    }

    public function OnItemsRepeaterElementIndexChanged (Closure $callback) {
        return ItemsRepeaterEventsExtensions::OnElementIndexChanged($this, $callback);
    }

    public function OnItemsRepeaterElementPrepared (Closure $callback) {
        return ItemsRepeaterEventsExtensions::OnElementPrepared($this, $callback);
    }
}

trait UxRichTextBlockEventsExtensions
{

    public function OnRichTextBlockCopyingToClipboard (Closure $callback) {
        return RichTextBlockEventsExtensions::OnCopyingToClipboard($this, $callback);
    }
}

trait UxScrollViewerEventsExtensions
{

    public function OnScrollViewerScrollChanged (Closure $callback) {
        return ScrollViewerEventsExtensions::OnScrollChanged($this, $callback);
    }
}

trait UxSpinnerEventsExtensions
{

    public function OnSpinnerSpin (Closure $callback) {
        return SpinnerEventsExtensions::OnSpin($this, $callback);
    }
}

trait UxSplitButtonEventsExtensions
{

    public function OnSplitButtonClick (Closure $callback) {
        return SplitButtonEventsExtensions::OnClick($this, $callback);
    }
}

trait UxToggleSplitButtonEventsExtensions
{

    public function OnToggleSplitButtonIsCheckedChanged (Closure $callback) {
        return ToggleSplitButtonEventsExtensions::OnIsCheckedChanged($this, $callback);
    }
}

trait UxSplitViewEventsExtensions
{

    public function OnSplitViewPaneClosed (Closure $callback) {
        return SplitViewEventsExtensions::OnPaneClosed($this, $callback);
    }

    public function OnSplitViewPaneClosing (Closure $callback) {
        return SplitViewEventsExtensions::OnPaneClosing($this, $callback);
    }

    public function OnSplitViewPaneOpened (Closure $callback) {
        return SplitViewEventsExtensions::OnPaneOpened($this, $callback);
    }

    public function OnSplitViewPaneOpening (Closure $callback) {
        return SplitViewEventsExtensions::OnPaneOpening($this, $callback);
    }
}

trait UxTextBoxEventsExtensions
{

    public function OnTextBoxCopyingToClipboard (Closure $callback) {
        return TextBoxEventsExtensions::OnCopyingToClipboard($this, $callback);
    }

    public function OnTextBoxCuttingToClipboard (Closure $callback) {
        return TextBoxEventsExtensions::OnCuttingToClipboard($this, $callback);
    }

    public function OnTextBoxPastingFromClipboard (Closure $callback) {
        return TextBoxEventsExtensions::OnPastingFromClipboard($this, $callback);
    }

    public function OnTextBoxTextChanged (Closure $callback) {
        return TextBoxEventsExtensions::OnTextChanged($this, $callback);
    }

    public function OnTextBoxTextChanging (Closure $callback) {
        return TextBoxEventsExtensions::OnTextChanging($this, $callback);
    }
}

trait UxTopLevelEventsExtensions
{

    public function OnTopLevelOpened (Closure $callback) {
        return TopLevelEventsExtensions::OnOpened($this, $callback);
    }

    public function OnTopLevelClosed (Closure $callback) {
        return TopLevelEventsExtensions::OnClosed($this, $callback);
    }
}

trait UxTrayIconEventsExtensions
{

    public function OnTrayIconClicked (Closure $callback) {
        return TrayIconEventsExtensions::OnClicked($this, $callback);
    }
}

trait UxTreeViewEventsExtensions
{

    public function OnTreeViewSelectionChanged (Closure $callback) {
        return TreeViewEventsExtensions::OnSelectionChanged($this, $callback);
    }
}

trait UxWindowEventsExtensions
{

    public function OnWindowClosing (Closure $callback) {
        return WindowEventsExtensions::OnClosing($this, $callback);
    }
}

trait UxWindowBaseEventsExtensions
{

    public function OnWindowBaseActivated (Closure $callback) {
        return WindowBaseEventsExtensions::OnActivated($this, $callback);
    }

    public function OnWindowBaseDeactivated (Closure $callback) {
        return WindowBaseEventsExtensions::OnDeactivated($this, $callback);
    }

    public function OnWindowBasePositionChanged (Closure $callback) {
        return WindowBaseEventsExtensions::OnPositionChanged($this, $callback);
    }
}

trait UxTextPresenterEventsExtensions
{

    public function OnTextPresenterCaretBoundsChanged (Closure $callback) {
        return TextPresenterEventsExtensions::OnCaretBoundsChanged($this, $callback);
    }
}

trait UxNotificationCardEventsExtensions
{

    public function OnNotificationCardNotificationClosed (Closure $callback) {
        return NotificationCardEventsExtensions::OnNotificationClosed($this, $callback);
    }
}

trait UxCalendarButtonEventsExtensions
{

    public function OnCalendarButtonCalendarLeftMouseButtonDown (Closure $callback) {
        return CalendarButtonEventsExtensions::OnCalendarLeftMouseButtonDown($this, $callback);
    }

    public function OnCalendarButtonCalendarLeftMouseButtonUp (Closure $callback) {
        return CalendarButtonEventsExtensions::OnCalendarLeftMouseButtonUp($this, $callback);
    }
}

trait UxCalendarDayButtonEventsExtensions
{

    public function OnCalendarDayButtonCalendarDayButtonMouseDown (Closure $callback) {
        return CalendarDayButtonEventsExtensions::OnCalendarDayButtonMouseDown($this, $callback);
    }

    public function OnCalendarDayButtonCalendarDayButtonMouseUp (Closure $callback) {
        return CalendarDayButtonEventsExtensions::OnCalendarDayButtonMouseUp($this, $callback);
    }
}

trait UxDateTimePickerPanelEventsExtensions
{

    public function OnDateTimePickerPanelScrollInvalidated (Closure $callback) {
        return DateTimePickerPanelEventsExtensions::OnScrollInvalidated($this, $callback);
    }

    public function OnDateTimePickerPanelSelectionChanged (Closure $callback) {
        return DateTimePickerPanelEventsExtensions::OnSelectionChanged($this, $callback);
    }
}

trait UxPickerPresenterBaseEventsExtensions
{

    public function OnPickerPresenterBaseConfirmed (Closure $callback) {
        return PickerPresenterBaseEventsExtensions::OnConfirmed($this, $callback);
    }

    public function OnPickerPresenterBaseDismissed (Closure $callback) {
        return PickerPresenterBaseEventsExtensions::OnDismissed($this, $callback);
    }
}

trait UxFlyoutBaseEventsExtensions
{

    public function OnFlyoutBaseClosed (Closure $callback) {
        return FlyoutBaseEventsExtensions::OnClosed($this, $callback);
    }

    public function OnFlyoutBaseClosing (Closure $callback) {
        return FlyoutBaseEventsExtensions::OnClosing($this, $callback);
    }

    public function OnFlyoutBaseOpened (Closure $callback) {
        return FlyoutBaseEventsExtensions::OnOpened($this, $callback);
    }

    public function OnFlyoutBaseOpening (Closure $callback) {
        return FlyoutBaseEventsExtensions::OnOpening($this, $callback);
    }
}

trait UxPopupEventsExtensions
{

    public function OnPopupClosed (Closure $callback) {
        return PopupEventsExtensions::OnClosed($this, $callback);
    }

    public function OnPopupOpened (Closure $callback) {
        return PopupEventsExtensions::OnOpened($this, $callback);
    }
}

trait UxScrollBarEventsExtensions
{

    public function OnScrollBarScroll (Closure $callback) {
        return ScrollBarEventsExtensions::OnScroll($this, $callback);
    }
}

trait UxSelectingItemsControlEventsExtensions
{

    public function OnSelectingItemsControlSelectionChanged (Closure $callback) {
        return SelectingItemsControlEventsExtensions::OnSelectionChanged($this, $callback);
    }
}

trait UxTemplatedControlEventsExtensions
{

    public function OnTemplatedControlTemplateApplied (Closure $callback) {
        return TemplatedControlEventsExtensions::OnTemplateApplied($this, $callback);
    }
}

trait UxThumbEventsExtensions
{

    public function OnThumbDragStarted (Closure $callback) {
        return ThumbEventsExtensions::OnDragStarted($this, $callback);
    }

    public function OnThumbDragDelta (Closure $callback) {
        return ThumbEventsExtensions::OnDragDelta($this, $callback);
    }

    public function OnThumbDragCompleted (Closure $callback) {
        return ThumbEventsExtensions::OnDragCompleted($this, $callback);
    }
}

trait UxToggleButtonEventsExtensions
{

    public function OnToggleButtonChecked (Closure $callback) {
        return ToggleButtonEventsExtensions::OnChecked($this, $callback);
    }

    public function OnToggleButtonUnchecked (Closure $callback) {
        return ToggleButtonEventsExtensions::OnUnchecked($this, $callback);
    }

    public function OnToggleButtonIndeterminate (Closure $callback) {
        return ToggleButtonEventsExtensions::OnIndeterminate($this, $callback);
    }
}

trait UxAvaloniaObjectEventsExtensions
{

    public function OnAvaloniaObjectPropertyChanged (Closure $callback) {
        return AvaloniaObjectEventsExtensions::OnPropertyChanged($this, $callback);
    }
}

trait UxStyledElementEventsExtensions
{

    public function OnStyledElementAttachedToLogicalTree (Closure $callback) {
        return StyledElementEventsExtensions::OnAttachedToLogicalTree($this, $callback);
    }

    public function OnStyledElementDetachedFromLogicalTree (Closure $callback) {
        return StyledElementEventsExtensions::OnDetachedFromLogicalTree($this, $callback);
    }

    public function OnStyledElementDataContextChanged (Closure $callback) {
        return StyledElementEventsExtensions::OnDataContextChanged($this, $callback);
    }

    public function OnStyledElementInitialized (Closure $callback) {
        return StyledElementEventsExtensions::OnInitialized($this, $callback);
    }

    public function OnStyledElementResourcesChanged (Closure $callback) {
        return StyledElementEventsExtensions::OnResourcesChanged($this, $callback);
    }
}

trait UxVisualEventsExtensions
{

    public function OnVisualAttachedToVisualTree (Closure $callback) {
        return VisualEventsExtensions::OnAttachedToVisualTree($this, $callback);
    }

    public function OnVisualDetachedFromVisualTree (Closure $callback) {
        return VisualEventsExtensions::OnDetachedFromVisualTree($this, $callback);
    }
}

trait UxStyleBaseEventsExtensions
{

    public function OnStyleBaseOwnerChanged (Closure $callback) {
        return StyleBaseEventsExtensions::OnOwnerChanged($this, $callback);
    }
}

trait UxStylesEventsExtensions
{

    public function OnStylesCollectionChanged (Closure $callback) {
        return StylesEventsExtensions::OnCollectionChanged($this, $callback);
    }

    public function OnStylesOwnerChanged (Closure $callback) {
        return StylesEventsExtensions::OnOwnerChanged($this, $callback);
    }
}

trait UxAttachedLayoutEventsExtensions
{

    public function OnAttachedLayoutMeasureInvalidated (Closure $callback) {
        return AttachedLayoutEventsExtensions::OnMeasureInvalidated($this, $callback);
    }

    public function OnAttachedLayoutArrangeInvalidated (Closure $callback) {
        return AttachedLayoutEventsExtensions::OnArrangeInvalidated($this, $callback);
    }
}

trait UxLayoutableEventsExtensions
{

    public function OnLayoutableEffectiveViewportChanged (Closure $callback) {
        return LayoutableEventsExtensions::OnEffectiveViewportChanged($this, $callback);
    }

    public function OnLayoutableLayoutUpdated (Closure $callback) {
        return LayoutableEventsExtensions::OnLayoutUpdated($this, $callback);
    }
}

trait UxBrushEventsExtensions
{

    public function OnBrushInvalidated (Closure $callback) {
        return BrushEventsExtensions::OnInvalidated($this, $callback);
    }
}

trait UxDashStyleEventsExtensions
{

    public function OnDashStyleInvalidated (Closure $callback) {
        return DashStyleEventsExtensions::OnInvalidated($this, $callback);
    }
}

trait UxDrawingImageEventsExtensions
{

    public function OnDrawingImageInvalidated (Closure $callback) {
        return DrawingImageEventsExtensions::OnInvalidated($this, $callback);
    }
}

trait UxExperimentalAcrylicMaterialEventsExtensions
{

    public function OnExperimentalAcrylicMaterialInvalidated (Closure $callback) {
        return ExperimentalAcrylicMaterialEventsExtensions::OnInvalidated($this, $callback);
    }
}

trait UxGeometryEventsExtensions
{

    public function OnGeometryChanged (Closure $callback) {
        return GeometryEventsExtensions::OnChanged($this, $callback);
    }
}

trait UxPenEventsExtensions
{

    public function OnPenInvalidated (Closure $callback) {
        return PenEventsExtensions::OnInvalidated($this, $callback);
    }
}

trait UxTransformEventsExtensions
{

    public function OnTransformChanged (Closure $callback) {
        return TransformEventsExtensions::OnChanged($this, $callback);
    }
}

trait UxCroppedBitmapEventsExtensions
{

    public function OnCroppedBitmapInvalidated (Closure $callback) {
        return CroppedBitmapEventsExtensions::OnInvalidated($this, $callback);
    }
}