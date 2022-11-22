<?php

namespace Forms;

use Controls\Button;
use Apf\Controls\{ UxWindow, UxStackPanel };

class MainWindow extends UxWindow {
     public function __construct() {

        $this->Title = "Панель примеров";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new Button();
        $OpenToDoListForm->Content = "ToDoListForm";

        $OpenToDoListForm->OnClick(function($RoutedEventArgs){
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });

        $UxStackPanel->Children->Add($OpenToDoListForm);

     }

}