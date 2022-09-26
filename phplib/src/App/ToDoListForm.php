<?php

namespace App;

use Apf\{
    Controls\UxButton,
    Controls\UxListBox,
    Controls\UxWindow,
    Controls\UxStackPanel,
    Controls\UxTextBox
};

use Avalonia\{
    Interactivity\RoutedEventArgs,
    Layout\Orientation
};

class ButtonAddItemToList extends UxButton {
    public function __construct()
    {
        $this->Content = "Добавить";
    }
}

class ButtonRemoveItemList extends UxButton {
    public function __construct()
    {
        $this->Content = "Удалить";
    }
}

class TextBoxContentItem extends UxTextBox {
    public function __construct()
    {
        $this->Width = 630;
    }
}

class ToDoListForm extends UxWindow
{
    #Panels
    public UxStackPanel $ToDoListContentPanel;
    public UxStackPanel $ToDoListControlsPanel;
    #Buttons
    public ButtonAddItemToList $ButtonAddItemToList;
    public ButtonRemoveItemList $ButtonRemoveItemList;
    #ListBox
    public UxListBox $ToDoList;
    #TextBox
    public TextBoxContentItem $TextBoxContentItem;

    public function __construct()
    {
        $this->ToDoListContentPanel = new UxStackPanel();
        $this->ToDoListControlsPanel = new UxStackPanel();
        $this->ButtonAddItemToList = new ButtonAddItemToList();
        $this->ButtonRemoveItemList = new ButtonRemoveItemList();
        $this->TextBoxContentItem = new TextBoxContentItem();
        $this->ToDoList = new UxListBox();

        $this->setupAssetViewerFormProperty();
        $this->addComponentsToDoListContentPanel();
        $this->addComponentsToDoListControlsPanel();
        $this->setControlEvents();
    }

    private function setupAssetViewerFormProperty(){
        $this->Title = "ToDoList";
        $this->Width = 800;
        $this->Height = 440;

        $this->Content = $this->ToDoListContentPanel;
    }

    private function addComponentsToDoListContentPanel(){
        $this->ToDoList->Height = 400;
        $this->ToDoListContentPanel->Children->Add($this->ToDoList);
        $this->ToDoListContentPanel->Children->Add($this->ToDoListControlsPanel);
    }

    private function addComponentsToDoListControlsPanel(){
        $this->ToDoListControlsPanel->Orientation = Orientation::$Horizontal;

        $this->ToDoListControlsPanel->Children->Add($this->TextBoxContentItem);
        $this->ToDoListControlsPanel->Children->Add($this->ButtonAddItemToList);
        $this->ToDoListControlsPanel->Children->Add($this->ButtonRemoveItemList);
    }

    private function setControlEvents(){
        //При нажатии кнопки добавляем текст в список задач
        $this->ButtonAddItemToList->Listener->Add($this->ButtonAddItemToList::$ClickEvent,"AddTextToListBox", function(ButtonAddItemToList $button, RoutedEventArgs $e){
            if($this->TextBoxContentItem->Text != ""){
                $this->ToDoList->Items->Add(trim($this->TextBoxContentItem->Text));
                $this->TextBoxContentItem->Text = "";
            }
        });
        //При нажатии кнопки удаляет выбранный текст из списка задач
        $this->ButtonRemoveItemList->Listener->Add($this->ButtonRemoveItemList::$ClickEvent,"AddTextToListBox", function(ButtonRemoveItemList $button, RoutedEventArgs $e){
            if($this->ToDoList->SelectedIndex != -1){
                $this->ToDoList->Items->RemoveAt($this->ToDoList->SelectedIndex);
            }
        });

    }
}