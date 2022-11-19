<?php
namespace Apf\Applications;

use Closure;

class UxApplication
{

    /**
     * @param Closure $callback
     * @param string $FluentThemeMode Dark or Light
     * @param array|null $args
     */
    public function __construct(Closure $callback, string $FluentThemeMode = "Dark", array $args = NULL)
    {
    }
}