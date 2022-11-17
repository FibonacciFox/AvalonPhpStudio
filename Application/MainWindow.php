<?php

use Apf\Controls\{ UxWindow, UxButton, UxStackPanel };

use Apf\Applications\UxInputElementEventsExtensions;

trait InputElementEvents {
    public UxInputElementEventsExtensions $UxInputElementEvents;

    public function InputElementEventsInit(): void
    {
        $this->UxInputElementEvents = new UxInputElementEventsExtensions($this);
    }

    public function OnInputPointerEntered(\Closure $callback): void
    {
        $this->UxInputElementEvents->OnPointerEntered($callback);
    }
}

class UxTraitButton extends UxButton {
    use InputElementEvents;

    public function __construct()
    {
        $this->InputElementEventsInit();

        $this->OnInputPointerEntered( function(){
            echo "Hi!";
        });
    }
}

class MainWindow extends UxWindow {
    
     public function __construct() {

        $this->Title = "Панель примеров";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;
        $OpenToDoListForm = new UxTraitButton();
        $OpenToDoListForm->Content = "ToDoListForm";

        $OpenToDoListForm->Listener->Add(UxButton::$ClickEvent,"ShowToDoList", function (UxButton $button, RoutedEventArgs $e){
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });


        $UxStackPanel->Children->Add($OpenToDoListForm);
     }

}