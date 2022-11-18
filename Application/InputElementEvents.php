<?php

use Apf\Applications\UxInputElementEvents;
use Avalonia\Input\InputElement;

trait InputElementEvents
{

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputGotFocus(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnGotFocus($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputLostFocus(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnLostFocus($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputKeyDown(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnKeyDown($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputKeyUp(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnKeyUp($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputTextInput(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnTextInput($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputTextInputMethodClientRequested(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnTextInputMethodClientRequested($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerEntered(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerEntered($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerExited(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerExited($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerMoved(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerMoved($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerPressed(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerPressed($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerReleased(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerReleased($this, $callback);
    }

    /**
     * Occurs when the control or its child control loses the pointer capture for any reason,
     * event will not be triggered for a parent control if capture was transferred to another
     * child of that parent control
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerCaptureLost(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerCaptureLost($this, $callback);
    }

    /**
     * Occurs when the mouse is scrolled over the control.
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputPointerWheelChanged(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnPointerWheelChanged($this, $callback);
    }

    /**
     * Occurs when a tap gesture occurs on the control.
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputTapped(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnTapped($this, $callback);
    }

    /**
     * Occurs when a double-tap gesture occurs on the control.
     * @param Closure $callback
     * @return InputElement
     */
    public function OnInputDoubleTapped(Closure $callback): InputElement
    {
        return UxInputElementEvents::OnDoubleTapped($this, $callback);
    }
}