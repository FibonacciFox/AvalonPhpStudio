<?php

namespace Avalonia\Controls;
/**
 *  Base class for top-level widgets.
 *
 * @property  Size $ClientSize Gets or sets the client size of the window.
 */
abstract class TopLevel extends ContentControl implements
        IInputRoot,
        ILayoutRoot,
        IRenderRoot,
        ICloseable,
        IStyleHost,
        ILogicalRoot,
        ITextInputMethodRoot
        //IWeakEventSubscriber<ResourcesChangedEventArgs>
{

}