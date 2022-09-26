<?php

namespace App;

use Apf\Controls\{ UxWindow, UxButton, UxStackPanel };


class MainWindow extends UxWindow {
    
     public function __construct() {

        $this->Title = "������ ��������";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;
        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Content = "ToDoListForm";

        $OpenToDoListForm->Listener->Add(UxButton::$ClickEvent,"ShowToDoList", function (UxButton $button, RoutedEventArgs $e){
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });


        $UxStackPanel->Children->Add($OpenToDoListForm);
     }

}