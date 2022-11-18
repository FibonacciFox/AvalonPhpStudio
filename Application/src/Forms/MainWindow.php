<?php

namespace Forms;

use InputElementEvents;
use Apf\Controls\{UxButton, UxWindow, UxStackPanel };

class MainWindow extends UxWindow {
    
     public function __construct() {

        $this->Title = "Панель примеров";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        //Test компонента основанного на трейтах
        $OpenToDoListForm = new class extends UxButton {
            use InputElementEvents;
        };

        $OpenToDoListForm->Content = "ToDoListForm";

        $OpenToDoListForm->OnClick(function($_) {
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });

        $UxStackPanel->Children->Add($OpenToDoListForm);
     }

}