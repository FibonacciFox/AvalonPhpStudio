<?php

namespace Forms;
use Controls\Button;
use Apf\{Controls\UxListBox, Controls\UxStackPanel, Controls\UxTextBox, Controls\UxWindow};
use Avalonia\{Layout\Orientation};

class ButtonAddItemToList extends Button {
    public function __construct()
    {
        $this->Content = "Добавить";
    }
}

class ButtonRemoveItemList extends Button {
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
        $this->ButtonAddItemToList->OnClick(function() {
            if($this->TextBoxContentItem->Text != ""){
                $this->ToDoList->Items->Add(trim($this->TextBoxContentItem->Text));
                $this->TextBoxContentItem->Text = "";
            }
        });
        //При нажатии кнопки удаляет выбранный текст из списка задач
        $this->ButtonRemoveItemList->OnClick(function() {
            if($this->ToDoList->SelectedIndex != -1){
                $index = $this->ToDoList->SelectedIndex;
                $this->ToDoList->Items->RemoveAt($this->ToDoList->SelectedIndex);
                $this->ToDoList->SelectedIndex = $index - 1;
            }
        });

    }
}