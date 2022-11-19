<?php

namespace Forms;

use InputElementEvents;
use Apf\Controls\UxWindow;

class Form3 extends UxWindow
{
    use InputElementEvents;
    public function __construct()
    {
        $this->Title = "Form3";
        $this->Height = 400;
        $this->Width = 400;

        $this->OnInputKeyUp(function($Args){
            $Form3 = new Form3();
            $Form3->Show();
        });
    }
}