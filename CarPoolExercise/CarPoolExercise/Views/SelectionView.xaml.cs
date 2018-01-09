﻿using System;
using System.Collections.Generic;
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

namespace CarPoolExercise.Views
{
    /// <summary>
    /// Interaktionslogik für SelectionView.xaml
    /// </summary>
    public partial class SelectionView : Window
    {
        private SelectionViewModel selectionViewModel;
        public SelectionView()
        {
            InitializeComponent();
            selectionViewModel = new SelectionViewModel();
            this.DataContext = selectionViewModel.cars;
        }

    }
}
