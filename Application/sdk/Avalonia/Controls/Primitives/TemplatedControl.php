<?php

namespace Avalonia\Controls\Primitives;

use Avalonia\Controls\Control;
use Avalonia\Media\IBrush;


/**
 * A lookless control whose visual appearance is defined by its Template"/>.
 * Displays Content according to FuncDataTemplate.
 *
 * @property IBrush $Background Gets or sets the content to display.
 * @property IBrush $BorderBrush Gets or sets the brush used to draw the control's border.
 * @property Thickness $BorderThickness Gets or sets the thickness of the control's border.
 * @property object $Content Gets or sets the content to display.
 */
class TemplatedControl extends Control implements ITemplatedControl
{

}