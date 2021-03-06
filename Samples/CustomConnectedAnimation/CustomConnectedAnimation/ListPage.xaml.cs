﻿using System.Collections.ObjectModel;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using CustomConnectedAnimation.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CustomConnectedAnimation
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ListPage_BackRequested;
        }

        public ObservableCollection<Photo> Photos { get; } = Photo.CreatePhotoCollection();

        private void ListPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested -= ListPage_BackRequested;
            Frame.GoBack();
        }
    }
}