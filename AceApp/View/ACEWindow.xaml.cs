﻿using AceApp.Model;
using AceApp.ViewModel;
using AceApp.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AceApp.View
{
    /// <summary>
    /// Interaction logic for ACEWindow.xaml
    /// </summary>
    public partial class ACEWindow : Window
    {
        public User User { get; set; }

        public ACEWindow()
        {
            InitializeComponent();
        }
    }
}