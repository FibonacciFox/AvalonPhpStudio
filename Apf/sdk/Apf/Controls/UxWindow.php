<?php

namespace Apf\Controls;

use Avalonia\Controls\Window;
use Avalonia\Controls\WindowTransparencyLevel;
use Avalonia\Media\IBrush;

/**
 * A top-level window.
 * @property string $Title Gets or sets the title of the window.
 * @property int $Width
 * @property int $Height
 * @property bool $CanResize Enables or disables resizing of the window.
 * Note that if HasSystemDecorations is set to False then this property
 * has no effect and should be treated as a recommendation for the user
 * setting HasSystemDecorations.
 * @property WindowTransparencyLevel $ActualTransparencyLevel Gets the achieved WindowTransparencyLevel that the platform was able to provide.
 * @property IBrush $BorderBrush Gets or sets the brush used to draw the control's border.
 * @property Thickness $BorderThickness Gets or sets the thickness of the control's border.
 * @property Rect $Bounds Gets the bounds of the control relative to its parent.
 */


class UxWindow extends Window
{


}