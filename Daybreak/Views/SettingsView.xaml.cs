﻿using Daybreak.Services.Configuration;
using Daybreak.Services.ViewManagement;
using Microsoft.Win32;
using System;
using System.Extensions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Extensions;

namespace Daybreak.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public static readonly DependencyProperty TexmodPathProperty =
            DependencyPropertyExtensions.Register<SettingsView, string>(nameof(TexmodPath));
        public static readonly DependencyProperty ToolboxPathProperty =
            DependencyPropertyExtensions.Register<SettingsView, string>(nameof(ToolboxPath));
        public static readonly DependencyProperty AddressBarReadonlyProperty =
            DependencyPropertyExtensions.Register<SettingsView, bool>(nameof(AddressBarReadonly));
        public static readonly DependencyProperty BrowsersEnabledProperty =
            DependencyPropertyExtensions.Register<SettingsView, bool>(nameof(BrowsersEnabled));
        public static readonly DependencyProperty LeftBrowserUrlProperty =
            DependencyPropertyExtensions.Register<SettingsView, string>(nameof(LeftBrowserUrl));
        public static readonly DependencyProperty RightBrowserUrlProperty =
            DependencyPropertyExtensions.Register<SettingsView, string>(nameof(RightBrowserUrl));
        public static readonly DependencyProperty ToolboxAutoLaunchProperty =
            DependencyPropertyExtensions.Register<SettingsView, bool>(nameof(ToolboxAutoLaunch));
        public static readonly DependencyProperty AutoPlaceOnScreenProperty =
            DependencyPropertyExtensions.Register<SettingsView, bool>(nameof(AutoPlaceOnScreen));
        public static readonly DependencyProperty DesiredScreenProperty =
            DependencyPropertyExtensions.Register<SettingsView, string>(nameof(DesiredScreen));

        private readonly IConfigurationManager configurationManager;
        private readonly IViewManager viewManager;

        public string TexmodPath
        {
            get => this.GetTypedValue<string>(TexmodPathProperty);
            set => this.SetValue(TexmodPathProperty, value);
        }
        public bool ToolboxAutoLaunch
        {
            get => this.GetTypedValue<bool>(ToolboxAutoLaunchProperty);
            set => this.SetValue(ToolboxAutoLaunchProperty, value);
        }
        public string ToolboxPath
        {
            get => this.GetTypedValue<string>(ToolboxPathProperty);
            set => this.SetValue(ToolboxPathProperty, value);
        }
        public bool AddressBarReadonly
        {
            get => this.GetTypedValue<bool>(AddressBarReadonlyProperty);
            set => this.SetValue(AddressBarReadonlyProperty, value);
        }
        public string LeftBrowserUrl
        {
            get => this.GetTypedValue<string>(LeftBrowserUrlProperty);
            set => this.SetValue(LeftBrowserUrlProperty, value);
        }
        public string RightBrowserUrl
        {
            get => this.GetTypedValue<string>(RightBrowserUrlProperty);
            set => this.SetValue(RightBrowserUrlProperty, value);
        }
        public bool BrowsersEnabled
        {
            get => this.GetTypedValue<bool>(BrowsersEnabledProperty);
            set => this.SetValue(BrowsersEnabledProperty, value);
        }
        public bool AutoPlaceOnScreen
        {
            get => this.GetTypedValue<bool>(AutoPlaceOnScreenProperty);
            set => this.SetValue(AutoPlaceOnScreenProperty, value);
        }
        public string DesiredScreen
        {
            get => this.GetTypedValue<string>(DesiredScreenProperty);
            set => this.SetValue(DesiredScreenProperty, value);
        }

        public SettingsView(
            IConfigurationManager configurationManager,
            IViewManager viewManager)
        {
            this.configurationManager = configurationManager.ThrowIfNull(nameof(configurationManager));
            this.viewManager = viewManager.ThrowIfNull(nameof(viewManager));
            this.InitializeComponent();
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            var config = this.configurationManager.GetConfiguration();
            this.AddressBarReadonly = config.AddressBarReadonly;
            this.ToolboxPath = config.ToolboxPath;
            this.LeftBrowserUrl = config.LeftBrowserDefault;
            this.RightBrowserUrl = config.RightBrowserDefault;
            this.ToolboxAutoLaunch = config.ToolboxAutoLaunch;
            this.TexmodPath = config.TexmodPath;
            this.BrowsersEnabled = config.BrowsersEnabled;
            this.AutoPlaceOnScreen = config.SetGuildwarsWindowSizeOnLaunch;
            this.DesiredScreen = config.DesiredGuildwarsScreen.ToString();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var currentConfig = this.configurationManager.GetConfiguration();
            currentConfig.ToolboxPath = this.ToolboxPath;
            currentConfig.AddressBarReadonly = this.AddressBarReadonly;
            currentConfig.LeftBrowserDefault = this.LeftBrowserUrl;
            currentConfig.RightBrowserDefault = this.RightBrowserUrl;
            currentConfig.ToolboxAutoLaunch = this.ToolboxAutoLaunch;
            currentConfig.TexmodPath = this.TexmodPath;
            currentConfig.BrowsersEnabled = this.BrowsersEnabled;
            currentConfig.SetGuildwarsWindowSizeOnLaunch = this.AutoPlaceOnScreen;
            currentConfig.DesiredGuildwarsScreen = int.Parse(this.DesiredScreen);
            this.configurationManager.SaveConfiguration(currentConfig);
            this.viewManager.ShowView<SettingsCategoryView>();
        }

        private void ToolboxFilePickerGlyph_Clicked(object sender, EventArgs e)
        {
            var filePicker = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "exe",
                Multiselect = false
            };
            if (filePicker.ShowDialog() is true)
            {
                this.ToolboxPath = filePicker.FileName;
            }
        }

        private void TexmodFilePickerGlyph_Clicked(object sender, EventArgs e)
        {
            var filePicker = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "exe",
                Multiselect = false
            };
            if (filePicker.ShowDialog() is true)
            {
                this.TexmodPath = filePicker.FileName;
            }
        }

        private void ScreenPickerGlyph_Clicked(object sender, EventArgs e)
        {
            this.viewManager.ShowView<ScreenChoiceView>();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            this.viewManager.ShowView<SettingsCategoryView>();
        }

        private void TextBox_AllowOnlyNumbers(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out _) is false)
            {
                e.Handled = true;
            }
        }
    }
}
