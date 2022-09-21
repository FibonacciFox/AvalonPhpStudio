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