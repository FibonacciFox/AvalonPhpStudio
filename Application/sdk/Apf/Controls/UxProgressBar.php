<?php

namespace Apf\Controls;


/**
 * @property UxEvents $Listener [description] 
 * @property float $IndeterminateStartingOffset [description] 
 * @property float $IndeterminateEndingOffset [description] 
 * @property-read ProgressBar+ProgressBarTemplateProperties $TemplateProperties [description] 
 * @property bool $IsIndeterminate [description] 
 * @property bool $ShowProgressText [description] 
 * @property Orientation $Orientation [description] 
 * @property float $Minimum [description] 
 * @property float $Maximum [description] 
 * @property float $Value [description] 
 * @property float $SmallChange [description] 
 * @property float $LargeChange [description] 
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
 * @property-read IStyledElement $Parent [description] 
 * @property IClock $Clock [description] 
 * @property Transitions $Transitions [description] 
 * @property object $Item [description] 
 * @property IBinding $Item [description] 
 */
class UxProgressBar {


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
