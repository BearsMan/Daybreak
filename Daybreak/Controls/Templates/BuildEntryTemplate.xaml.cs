﻿using Daybreak.Models.Builds;
using System;
using System.Windows.Controls;

namespace Daybreak.Controls;

/// <summary>
/// Interaction logic for BuildEntryTemplate.xaml
/// </summary>
public partial class BuildEntryTemplate : UserControl
{
    public event EventHandler<BuildEntry>? RemoveClicked;
    public event EventHandler<BuildEntry>? EntryClicked;

    public BuildEntryTemplate()
    {
        this.InitializeComponent();
    }

    private void BinButton_Clicked(object _, EventArgs __)
    {
        if (this.DataContext is BuildEntry buildEntry)
        {
            this.RemoveClicked?.Invoke(this, buildEntry);
        }
    }

    private void HighlightButton_Clicked(object _, EventArgs __)
    {
        if (this.DataContext is BuildEntry buildEntry)
        {
            this.EntryClicked?.Invoke(this, buildEntry);
        }
    }
}
