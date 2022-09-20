<?php

namespace Avalonia\Controls;

/**
 * @property  bool $CanResize Enables or disables resizing of the window.
 * Note that if HasSystemDecorations is set to False then this property
 * has no effect and should be treated as a recommendation for the user setting HasSystemDecorations.
 */
class Window extends WindowBase implements IStyleable, IFocusScope, ILayoutRoot
{

}