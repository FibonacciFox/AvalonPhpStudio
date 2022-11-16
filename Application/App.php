<?php

use Apf\Applications\UXApplication;

$app = new UXApplication( function() {
    return new ToDoListForm();
});


