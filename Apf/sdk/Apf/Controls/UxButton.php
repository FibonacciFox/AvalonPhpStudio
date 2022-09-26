<?php

namespace Apf\Controls;


/**
 * A button control.
 */
class UxButton
{

    /**
     * Gets or sets the content to display.
     * @var mixed UxContent
     */
    public mixed $Content;

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

}