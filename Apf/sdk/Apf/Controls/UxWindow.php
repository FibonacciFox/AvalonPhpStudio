<?php

namespace Apf\Controls;


/**
 * @property UxEvents $Listener [description] 
 * @property-read IWindowImpl $PlatformImpl [description] 
 * @property-read mixed $OwnedWindows [description] 
 * @property SizeToContent $SizeToContent [description] 
 * @property string $Title [description] 
 * @property bool $HasSystemDecorations [description] 
 * @property bool $ExtendClientAreaToDecorationsHint [description] 
 * @property ExtendClientAreaChromeHints $ExtendClientAreaChromeHints [description] 
 * @property float $ExtendClientAreaTitleBarHeightHint [description] 
 * @property-read bool $IsExtendedIntoWindowDecorations [description] 
 * @property-read Thickness $WindowDecorationMargin [description] 
 * @property-read Thickness $OffScreenMargin [description] 
 * @property SystemDecorations $SystemDecorations [description] 
 * @property bool $ShowActivated [description] 
 * @property bool $ShowInTaskbar [description] 
 * @property WindowState $WindowState [description] 
 * @property bool $CanResize [description] 
 * @property WindowIcon $Icon [description] 
 * @property WindowStartupLocation $WindowStartupLocation [description] 
 * @property PixelPoint $Position [description] 
 //* @property-read IWindowBaseImpl $PlatformImpl [description]
 * @property-read bool $IsActive [description] 
 * @property-read Screens $Screens [description] 
 * @property WindowBase $Owner [description] 
 * @property bool $Topmost [description] 
 * @property Size $ClientSize [description] 
 * @property mixed $FrameSize [description] 
 * @property WindowTransparencyLevel $TransparencyLevelHint [description] 
 * @property-read WindowTransparencyLevel $ActualTransparencyLevel [description] 
 * @property IBrush $TransparencyBackgroundFallback [description] 
 * @property-read ILayoutManager $LayoutManager [description] 
 //* @property-read ITopLevelImpl $PlatformImpl [description]
 * @property-read IRenderer $Renderer [description] 
 * @property object $Content [description] 
 * @property IDataTemplate $ContentTemplate [description] 
 * @property-read IContentPresenter $Presenter [description] 
 * @property HorizontalAlignment $HorizontalContentAlignment [description] 
 * @property VerticalAlignment $VerticalContentAlignment [description] 
 * @property IBrush $Background [description] 
 * @property IBrush $BorderBrush [description] 
 * @property Thickness $BorderThickness [description] 
 * @property CornerRadius $CornerRadius [description] 
 * @property FontFamily $FontFamily [description] 
 * @property float $FontSize [description] 
 * @property FontStyle $FontStyle [description] 
 * @property FontWeight $FontWeight [description] 
 * @property IBrush $Foreground [description] 
 * @property Thickness $Padding [description] 
 * @property IControlTemplate $Template [description] 
 * @property mixed $FocusAdorner [description] 
 * @property-read DataTemplates $DataTemplates [description] 
 * @property ContextMenu $ContextMenu [description] 
 * @property FlyoutBase $ContextFlyout [description] 
 * @property object $Tag [description] 
 * @property-read IControl $Parent [description] 
 * @property bool $Focusable [description] 
 * @property bool $IsEnabled [description] 
 * @property Cursor $Cursor [description] 
 * @property bool $IsKeyboardFocusWithin [description] 
 * @property-read bool $IsFocused [description] 
 * @property bool $IsHitTestVisible [description] 
 * @property bool $IsPointerOver [description] 
 * @property bool $IsTabStop [description] 
 * @property-read bool $IsEffectivelyEnabled [description] 
 * @property int $TabIndex [description] 
 * @property-read mixed $KeyBindings [description] 
 * @property-read GestureRecognizerCollection $GestureRecognizers [description] 
 * @property float $Width [description] 
 * @property float $Height [description] 
 * @property float $MinWidth [description] 
 * @property float $MaxWidth [description] 
 * @property float $MinHeight [description] 
 * @property float $MaxHeight [description] 
 * @property Thickness $Margin [description] 
 * @property HorizontalAlignment $HorizontalAlignment [description] 
 * @property VerticalAlignment $VerticalAlignment [description] 
 * @property-read Size $DesiredSize [description] 
 * @property-read bool $IsMeasureValid [description] 
 * @property-read bool $IsArrangeValid [description] 
 * @property bool $UseLayoutRounding [description] 
 * @property Rect $Bounds [description] 
 * @property-read mixed $TransformedBounds [description] 
 * @property bool $ClipToBounds [description] 
 * @property Geometry $Clip [description] 
 * @property-read bool $IsEffectivelyVisible [description] 
 * @property bool $IsVisible [description] 
 * @property float $Opacity [description] 
 * @property IBrush $OpacityMask [description] 
 * @property ITransform $RenderTransform [description] 
 * @property RelativePoint $RenderTransformOrigin [description] 
 * @property int $ZIndex [description] 
 * @property string $Name [description] 
 * @property Classes $Classes [description] 
 * @property object $DataContext [description] 
 * @property-read bool $IsInitialized [description] 
 * @property-read Styles $Styles [description] 
 * @property IResourceDictionary $Resources [description] 
 * @property ITemplatedControl $TemplatedParent [description] 
 //* @property-read IStyledElement $Parent [description]
 * @property IClock $Clock [description] 
 * @property Transitions $Transitions [description] 
 * @property object $Item [description] 
 //* @property IBinding $Item [description]
 */
class UxWindow {


 public static Event $ClosingEvent;

 public static Event $ActivatedEvent;

 public static Event $DeactivatedEvent;

 public static Event $PositionChangedEvent;

 public static Event $OpenedEvent;

 public static Event $ClosedEvent;

 public static Event $TemplateAppliedEvent;

 public static Event $ContextRequestedEvent;

 public static Event $GotFocusEvent;

 public static Event $LostFocusEvent;

 public static Event $KeyDownEvent;

 public static Event $KeyUpEvent;

 public static Event $TextInputEvent;

 public static Event $TextInputMethodClientRequestedEvent;

 public static Event $TextInputOptionsQueryEvent;

 public static Event $PointerEnterEvent;

 public static Event $PointerLeaveEvent;

 public static Event $PointerMovedEvent;

 public static Event $PointerPressedEvent;

 public static Event $PointerReleasedEvent;

 public static Event $PointerCaptureLostEvent;

 public static Event $PointerWheelChangedEvent;

 public static Event $TappedEvent;

 public static Event $DoubleTappedEvent;

 public static Event $EffectiveViewportChangedEvent;

 public static Event $LayoutUpdatedEvent;

 public static Event $AttachedToVisualTreeEvent;

 public static Event $DetachedFromVisualTreeEvent;

 public static Event $AttachedToLogicalTreeEvent;

 public static Event $DetachedFromLogicalTreeEvent;

 public static Event $DataContextChangedEvent;

 public static Event $InitializedEvent;

 public static Event $ResourcesChangedEvent;

 public static Event $PropertyChangedEvent;

}
