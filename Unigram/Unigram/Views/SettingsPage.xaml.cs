﻿using System;
using System.Diagnostics;
using Unigram.Common;
using Unigram.Core.Dependency;
using Unigram.ViewModels;
using Unigram.Views.Settings;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Unigram.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsViewModel ViewModel => DataContext as SettingsViewModel;

        public SettingsPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;

            DataContext = UnigramContainer.Instance.ResolveType<SettingsViewModel>();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {

            OnStateChanged(null, null);
        }

        private void OnStateChanged(object p1, object p2)
        {
            
        }

        RelayCommand NotifcationPageCommand => new RelayCommand(() => MasterDetail.NavigationService.Navigate(typeof(SettingsNotificationsPage)));
        RelayCommand PrivacyPageCommand => new RelayCommand(() => MasterDetail.NavigationService.Navigate(typeof(SettingsPrivacyPage)));
        RelayCommand ChatSettingsPageCommand => new RelayCommand(() => MasterDetail.NavigationService.Navigate(typeof(SettingsChatPage)));
        RelayCommand StickersPageCommand => new RelayCommand(() => MasterDetail.NavigationService.Navigate(typeof(SettingStickersPage)));
        RelayCommand WallpaperPageCommand => new RelayCommand(() => MasterDetail.NavigationService.Navigate(typeof(SettingsWallpaperPage)));

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }

            if (MasterDetail.NavigationService == null)
            {
                MasterDetail.Initialize("Settings");
            }

            ViewModel.NavigationService = MasterDetail.NavigationService;
        }
    }
}
