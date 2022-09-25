﻿using Apf.Interactivity;
using Avalonia.Controls;

namespace Apf.Controls;

public class UxDockPanel : DockPanel
{
    /// <summary>
    /// События  <see cref="UxDockPanel.Listener"/>
    /// </summary>
    public UxEvents Listener;

    public UxDockPanel()
    {
        Listener = new UxEvents(this);
    }

}