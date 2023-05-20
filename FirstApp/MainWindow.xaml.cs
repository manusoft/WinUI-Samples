// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace FirstApp;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private async void myButton_Click(object sender, RoutedEventArgs e)
    {
        ContentDialog dialog = new ContentDialog();
        dialog.XamlRoot = this.Content.XamlRoot;
        dialog.Title = "Welcome";
        dialog.Content = txtName.Text;
        dialog.PrimaryButtonText = "OK";

        await dialog.ShowAsync();
    }
}
