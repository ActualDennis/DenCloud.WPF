﻿using CloudStorageFTP.WPF.ViewModels;
using System.Windows;

namespace CloudStorageFTP.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
    }
}
