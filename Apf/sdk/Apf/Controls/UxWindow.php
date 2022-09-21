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
     * Fired when the window is activated.
     * --RU--
     * Срабатывает, когда окно активировано.
     * @var RoutedEvent
     */
    public static RoutedEvent $AttachedToLogicalTreeEvent;
    /**
     * --EN--
     * Fired when the window is activated.
     * --RU--
     * Срабатывает, когда окно активировано.
     * @var RoutedEvent
     */
    public static RoutedEvent $Closed;

}