﻿using System.Windows;
using System.Windows.Controls;

namespace Kefka.Views.Openers
{
    /// <summary>
    /// Interaction logic for Opener.xaml
    /// </summary>
    public partial class Shadow_Opener : UserControl
    {
        public Shadow_Opener()
        {
            InitializeComponent();
        }

        private void SearchAction_OnGotFocus(object sender, RoutedEventArgs e)
        {
            SearchAction.Text = "";
        }

        private void SearchAction_OnLostFocus(object sender, RoutedEventArgs e)
        {
            SearchAction.Text = "Enter Spell Name and Press Enter... ";
        }
    }
}