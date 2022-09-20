<?php

namespace Avalonia;

use Avalonia\Animation\Animatable;

/**
 *  Extends an Animatable with the following features:
 * - An inherited DataContext
 * - Implements IStyleable to allow styling to work on the styled element.
 * - Implements ILogical  to form part of a logical tree.
 * - A collection of class strings for custom styling.
 */
class StyledElement extends Animatable implements IDataContextProvider, IStyledElement, ISetLogicalParent, ISetInheritanceParent
{

}