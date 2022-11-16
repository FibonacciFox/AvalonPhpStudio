<?php

use Apf\Applications\UxApplication;

$args = array("a","b");

$UxApplication = new UxApplication( function() {
    return new MainWindow();
}, FluentThemeMode: "Dark");


