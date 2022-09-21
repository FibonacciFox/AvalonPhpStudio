<?php

namespace MyWindow;

use Apf\{

    Platform\AssetLoader,
    Media\Imaging\UxBitmap,
    Controls\UxButton,
    Controls\UxDockPanel,
    Controls\UxListBox,
    Controls\UxNumericUpDown,
    Controls\Primitives\UxToggleButton,
    Controls\UxRadioButton,
    Controls\UxWindow,
    Controls\UxImage};


use Avalonia\{
    Controls\ControlExtensions,
    Controls\StackPanel,
    Markup\Xaml\AvaloniaRuntimeXamlLoader,
    Media\Imaging\Bitmap,
    Media\Brushes,
    Interactivity\RoutedEventArgs,
    Layout\HorizontalAlignment,
    Layout\VerticalAlignment
};

use System\{Uri};

use Pchp\Core\PhpValue;

//$file = AssetLoader::Open(new Uri($assets[3]));
//$loader = AvaloniaRuntimeXamlLoader::Parse($file);
//$loader->Show();

class Button extends  UxButton{

}

class MainWindow extends UxWindow {
    
     public function __construct() {


         $DockPanel1 = new UxDockPanel();
         $StackPanel = new StackPanel();
         

         $button = new UxButton();
         $button->HorizontalAlignment = HorizontalAlignment::Center;
         $button->Content = "Сменить по индексу";


         $image = new UxImage();
         $image->Width = 150;
         $image->Height = 150;

         $assets = AssetLoader::GetAssets(new Uri("avares://phplib/Assets"));
         $UxListBox = new UxListBox();
         $UxListBox->Items = $assets;
         $UxListBox->SelectedIndex = 0;
         $Avatar = AssetLoader::Open($assets[0]);
         $image->Source = new UxBitmap( $Avatar );

         $data = 100;

         //Обратите внимание- параметр $button имеет тип UxButton, т.к событие вызывает кнопка. Тип можно не указывать, по умолчанию равен object.
         $OnImageChangeIndex = function (UxButton $button, RoutedEventArgs $e) use($image, $assets, $UxListBox, $data) {
             $SelectedIndex = $UxListBox->SelectedIndex;
             $this->Title = $assets[$SelectedIndex];
             $Avatar = AssetLoader::Open($assets[$SelectedIndex]);
             $image->Source = new UxBitmap( $Avatar );

             //Передача параметров в Content пока только так PhpValue::FromClass($data);
             $button->Content = PhpValue::FromClass("Сменить:" . $SelectedIndex);

         };


         //Посмотреть все ивенты как и любого другого компонента ( например UxButton::$ClickEvent) можно по ссылке :
         // http://reference.avaloniaui.net/api/Avalonia.Controls/Button/#Events

         //Add([любой ивент], [Id для именования события], [анонимная функция])
         $button->Listener->Add(UxButton::$ClickEvent, "OnImageChangeIndex", $OnImageChangeIndex);

         //Для понимания как это работает посмотрите UxEvents.cs.
         //Чтобы события у компонента работали, нужно обернуть в класс UxНазвание компонента.
         //Добавить публичное поле public UxEvents Listener;
         // и инициализировать в конструкторе класс передав this класса компонента. см класс UxContentControl
         //В будущем такой строгой привязки не будет. События будут как отдельный статичный класс



		$this->Content = $DockPanel1;
        $DockPanel1->Children->Add($StackPanel);
        $StackPanel->Children->Add($image);
        $StackPanel->Children->Add($button);
        $DockPanel1->Children->Add($UxListBox);
        
        $UxNumericUpDown = new UxNumericUpDown();
        
        $UxNumericValueChanged = function(UxNumericUpDown $UxNumericUpDown , RoutedEventArgs $e ) {
           $this->Title = $UxNumericUpDown->Value;
        };
        
        $UxNumericUpDown->Listener->Add(UxNumericUpDown::$ValueChangedEvent, "UxNumericValueChanged", $UxNumericValueChanged);
     
        $StackPanel->Children->Add($UxNumericUpDown);


        $UxRadioButton = new UxRadioButton();
         $StackPanel->Children->Add($UxRadioButton);

         /*$class_vars = get_class_vars(get_class(new Button()));

         $i = 0;

         foreach ($class_vars as $name => $value) {
             if(strpos($name, "Event")) {
                 $UxListBox->Items[$i] = $name;
                 $this->Title = $name;
                 $i++;
             }
         }*/
     }

}