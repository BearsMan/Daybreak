﻿using Daybreak.Models;
using Daybreak.Models.Builds;
using Daybreak.Services.BuildTemplates;
using Daybreak.Services.Navigation;
using Daybreak.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Extensions;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Extensions;

namespace Daybreak.Views;

/// <summary>
/// Interaction logic for BuildsListView.xaml
/// </summary>
public partial class BuildsListView : UserControl
{
    private readonly IViewManager viewManager;
    private readonly IBuildTemplateManager buildTemplateManager;

    private IEnumerable<BuildEntry>? buildEntries;

    [GenerateDependencyProperty]
    private bool loading;

    public SortedObservableCollection<BuildEntry, string> BuildEntries { get; } = new SortedObservableCollection<BuildEntry, string>(entry => entry.Name!);

    public BuildsListView(
        IViewManager viewManager,
        IBuildTemplateManager buildTemplateManager)
    {
        this.viewManager = viewManager.ThrowIfNull(nameof(viewManager));
        this.buildTemplateManager = buildTemplateManager.ThrowIfNull(nameof(buildTemplateManager));
        this.InitializeComponent();
        this.LoadBuilds();
    }

    private async void LoadBuilds()
    {
        this.Loading = true;
        this.buildEntries = await this.buildTemplateManager.GetBuilds().ToListAsync();
        this.BuildEntries.ClearAnd().AddRange(this.buildEntries.OrderBy(b => b.Name));
        this.Loading = false;
        this.SearchTextBox.FocusOnTextBox();
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        var build = this.buildTemplateManager.CreateBuild();
        this.viewManager.ShowView<BuildTemplateView>(build);
    }

    private void BuildEntryTemplate_RemoveClicked(object _, BuildEntry e)
    {
        this.buildTemplateManager.RemoveBuild(e);
        this.LoadBuilds();
    }

    private void SearchTextBox_TextChanged(object _, string e)
    {
        var selectedEntries = this.buildEntries!.Where(b => StringUtils.MatchesSearchString(b.Name!, e));

        var entriesToRemove = this.BuildEntries.Except(selectedEntries).ToList();
        var entriesToAdd = selectedEntries.Except(this.BuildEntries).ToList();
        foreach(var buildEntry in  entriesToRemove)
        {
            this.BuildEntries.Remove(buildEntry);
        }

        foreach(var buildEntry in entriesToAdd)
        {
            this.BuildEntries.Add(buildEntry);
        }
    }

    private void SynchronizeButton_Clicked(object _, EventArgs __)
    {
        this.viewManager.ShowView<BuildsSynchronizationView>();
    }

    private void BuildEntryTemplate_EntryClicked(object _, BuildEntry e)
    {
        this.viewManager.ShowView<BuildTemplateView>(e);
    }
}
