<?php

namespace Apf\Controls;


/**
 * A button control.
 */
class UxButton
{

    /**
     * Gets or sets the content to display.
     * @var object UxContent
     */
    public object $Content;

    /**
     * Gets or sets the string content to display.
     * @var string
     */
    public string $Text;
    public UxEvents $Listener;

    /**
     * Initializes static members of the <see cref="UxButton"/> class.
     */
    public function __construct()
    {
    }

    /**
     * @param string $string  eventTag - тэг по которому будут отслеживаться события.
     * @param \Closure $param
     * @return void
     */
    public function On(string $string, \Closure $param) : void {

    }
}