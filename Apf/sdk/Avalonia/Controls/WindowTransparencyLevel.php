<?php
namespace Avalonia\Controls;

enum WindowTransparencyLevel
{

    /**
     * The window background is Black where nothing is drawn in the window.
     */
case None;
    /**
     * The window background is Transparent where nothing is drawn in the window.
     */
case Transparent;

    /**
     * The window background is a blur-behind where nothing is drawn in the window.
     */
case Blur;
    /**
     * The window background is a blur-behind with a high blur radius. This level may fallback to Blur.
     */
case AcrylicBlur;

    /// <summary>
    /// Force acrylic on some incompatible versions of Windows 10.
    /// </summary>
case ForceAcrylicBlur;

    /// <summary>
    /// The window background is based on desktop wallpaper tint with a blur. This will only work on Windows 11
    /// </summary>
case Mica;

}