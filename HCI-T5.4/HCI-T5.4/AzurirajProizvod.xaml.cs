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

namespace HCI_T5._4
{
    /// <summary>
    /// Interaction logic for AzurirajProizvod.xaml
    /// </summary>
    public partial class AzurirajProizvod : Window
    {
        public AzurirajProizvod()
        {
            InitializeComponent();
        }

        private void HelpBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string str = "azurirajProizvod";
            HelpProvider.ShowHelp(str);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

    }
}


