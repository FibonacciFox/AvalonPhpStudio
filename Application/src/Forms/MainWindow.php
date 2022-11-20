<?php

namespace Forms;

use Controls\Button;
use InputElementEvents;
use Apf\Controls\{ UxWindow, UxStackPanel };

class MainWindow extends UxWindow {
    use InputElementEvents;
     public function __construct() {

        $this->Title = "Панель примеров";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new Button();
        $OpenToDoListForm->Content = "ToDoListForm";

        $OpenToDoListForm->OnClick(function(){
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });

        $UxStackPanel->Children->Add($OpenToDoListForm);

     }

}