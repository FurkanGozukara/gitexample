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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace github_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("example click");
            return;
        }

        private void newfunction()
        {
            localMath mylocalMath = new localMath();
            var vrResult = mylocalMath.returnSquare(3423);
        }
    }
}
