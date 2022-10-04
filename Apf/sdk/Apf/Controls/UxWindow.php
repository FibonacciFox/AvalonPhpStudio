<?php

namespace Apf\Controls;


use Avalonia\Interactivity\RoutedEvent;

/**
 * Class UXWindow
 * @package Apf\Controls
 * @packages Controls, Avalonia
 *
 */
class UxWindow
{
    /**
     * Gets the acheived WindowTransparencyLevel that the platform was able to provide.
     * @var Level
     */
    public Level $ActualLevel;


    /**
     * Whether an auto-size operation is in progress.
     * @var bool
     */
    public bool $AutoSizing;

    /**
     * Gets or sets the brush used to draw the control's background.
     * @var IBrush
     */
    public IBrush $Background;

    /**
     * Gets or sets the brush used to draw the control's border.
     * @var IBrush
     */
    public IBrush $BorderBrush;

    /**
     * Gets or sets the thickness of the control's border.
     * @var Thickness
     */
    public Thickness $BorderThickness;

    /**
     * Gets the bounds of the control relative to its parent.
     * @var Rect
     */
    public Rect $Bounds;

    /**
     * Enables or disables resizing of the window.
     * Note that if HasSystemDecorations is set to
     * False then this property has no effect and
     * should be treated as a recommendation for
     * the user setting HasSystemDecorations.
     * @var bool
     */
    public bool $CanResize;

    /**
     * Gets or sets the styled element's classes.
     * @var Classes
     */
    public Classes $Classes;

    /**
     * Gets or sets the client size of the window.
     * @var Size
     */
    public Size $ClientSize;

    /**
     * The window title
     * @var string
     */
    public string $Title;

    /**
     * Gets or sets the geometry clip for this visual.
     * @var Geometry
     */
    public Geometry $Clip;

    /**
     * Gets or sets a value indicating whether the control should be clipped to its bounds.
     * @var bool
     */
    public bool $ClipToBounds;
    /**
     * --EN--
     * Fired when the window is activated.
     * --RU--
     * Срабатывает, когда окно активировано.
     * @var RoutedEvent
     */
    public static RoutedEvent $ActivatedEvent;

    /**
     * --EN--
     * Raised when the styled element is attached to a rooted logical tree.
     * --RU--
     * Возникает, когда стилизованный элемент присоединен к корневому логическому дереву.
     * @var RoutedEvent
     */
    public static RoutedEvent $AttachedToLogicalTreeEvent;

    /**
     * --EN--
     * Raised when the control is attached to a rooted visual tree.
     * --RU--
     * Вызывается, когда элемент управления прикреплен к корневому визуальному дереву.
     * @var RoutedEvent
     */
    public static RoutedEvent $AttachedToVisualTreeEvent;

    /**
     * --EN--
     * Fired when the window is closed.
     * --RU--
     * Вызывается, когда окно закрыто.
     * @var EventHandler<CancelEventArgs>
     */
    // public static EventHandler<CancelEventArgs> $Closed;

    /**
     * --EN--
     * Fired before a window is closed.
     * --RU--
     * Вызывается перед закрытием окна.
     * @var RoutedEvent
     */
    // EventHandler<CancelEventArgs> public static RoutedEvent $Closing;



}