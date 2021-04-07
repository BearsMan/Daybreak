﻿using Daybreak.Configuration;
using Daybreak.Models;
using Daybreak.Services.Credentials;
using Daybreak.Services.ViewManagement;
using Microsoft.Win32;
using Palletizer.WPF.Services.ConfigurationManager;
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
        private readonly IConfigurationManager configurationManager;
        private readonly ICredentialManager credentialManager;
        private readonly IViewManager viewManager;

        public SettingsView(
            IConfigurationManager configurationManager,
            ICredentialManager credentialManager,
            IViewManager viewManager)
        {
            this.configurationManager = configurationManager.ThrowIfNull(nameof(configurationManager));
            this.credentialManager = credentialManager.ThrowIfNull(nameof(credentialManager));
            this.viewManager = viewManager.ThrowIfNull(nameof(viewManager));
            this.InitializeComponent();
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            var config = this.configurationManager.GetConfiguration();
            var creds = this.credentialManager.GetCredentials();
            this.UsernameTextbox.Text = creds.Username;
            this.PasswordBox.Password = creds.Password;
            this.CharacterTextbox.Text = config.CharacterName;
            this.GamePathTextbox.Text = config.GamePath;
        }

        private void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            var currentConfig = this.configurationManager.GetConfiguration();
            currentConfig.CharacterName = this.CharacterTextbox.Text;
            currentConfig.GamePath = this.GamePathTextbox.Text;
            this.configurationManager.SaveConfiguration(currentConfig);
            this.credentialManager.StoreCredentials(new LoginCredentials { Username = this.UsernameTextbox.Text, Password = this.PasswordBox.Password });
            this.viewManager.ShowView<StartupView>();
        }

        private void FilePickerGlyph_Clicked(object sender, System.EventArgs e)
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
                this.GamePathTextbox.Text = filePicker.FileName;
            }
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            this.viewManager.ShowView<StartupView>();
        }
    }
}
