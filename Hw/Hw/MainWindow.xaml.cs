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

namespace Hw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private const int WindowSize = 600;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeBtnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поздравляю, вы выиграли!");
        }

        private void ClickMeBtnMouseEnter(object sender, MouseEventArgs e)
        {
            var bot = random.Next(WindowSize * 2) - WindowSize;
            var left = random.Next(WindowSize * 2) - WindowSize;
            clickMeBtn.Margin = new Thickness(left, 0, 0, bot);
        }
    }
}
