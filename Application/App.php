<?php

use Apf\Applications\UxApplication;

$UxApplication = new UxApplication( callback: function() {
    return new MainWindow();
}, FluentThemeMode: "Dark");


