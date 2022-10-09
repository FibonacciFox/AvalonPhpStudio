<?php

namespace Apf\Controls;

class UxProgressBar {
 public float $IndeterminateStartingOffset;
 public float $IndeterminateEndingOffset;
 //public ProgressBar+ProgressBarTemplateProperties $TemplateProperties;
 public bool $IsIndeterminate;
 public bool $ShowProgressText;
 public Orientation $Orientation;
 public float $Minimum;
 public float $Maximum;
 public float $Value;
 public float $SmallChange;
 public float $LargeChange;
 public IBrush $Background;
 public IBrush $BorderBrush;
 public Thickness $BorderThickness;
 public CornerRadius $CornerRadius;
 public FontFamily $FontFamily;
 public float $FontSize;
 public FontStyle $FontStyle;
 public FontWeight $FontWeight;
 public IBrush $Foreground;
 public Thickness $Padding;
 public IControlTemplate $Template;
 public mixed $FocusAdorner;
 public DataTemplates $DataTemplates;
 public ContextMenu $ContextMenu;
 public FlyoutBase $ContextFlyout;
 public object $Tag;
 public IControl $Parent;
 public bool $Focusable;
 public bool $IsEnabled;
 public Cursor $Cursor;
 public bool $IsKeyboardFocusWithin;
 public bool $IsFocused;
 public bool $IsHitTestVisible;
 public bool $IsPointerOver;
 public bool $IsTabStop;
 public bool $IsEffectivelyEnabled;
 public int $TabIndex;
 public mixed $KeyBindings;
 public GestureRecognizerCollection $GestureRecognizers;
 public float $Width;
 public float $Height;
 public float $MinWidth;
 public float $MaxWidth;
 public float $MinHeight;
 public float $MaxHeight;
 public Thickness $Margin;
 public HorizontalAlignment $HorizontalAlignment;
 public VerticalAlignment $VerticalAlignment;
 public Size $DesiredSize;
 public bool $IsMeasureValid;
 public bool $IsArrangeValid;
 public bool $UseLayoutRounding;
 public Rect $Bounds;
 public mixed $TransformedBounds;
 public bool $ClipToBounds;
 public Geometry $Clip;
 public bool $IsEffectivelyVisible;
 public bool $IsVisible;
 public float $Opacity;
 public IBrush $OpacityMask;
 public ITransform $RenderTransform;
 public RelativePoint $RenderTransformOrigin;
 public int $ZIndex;
 public string $Name;
 public Classes $Classes;
 public object $DataContext;
 public bool $IsInitialized;
 public Styles $Styles;
 public IResourceDictionary $Resources;
 public ITemplatedControl $TemplatedParent;
 //public IStyledElement $Parent;
 public IClock $Clock;
 public Transitions $Transitions;
 public object $Item;
 //public IBinding $Item;
}