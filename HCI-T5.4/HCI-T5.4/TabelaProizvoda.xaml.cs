﻿using HCI_T5._4.modeli;
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

namespace HCI_T5._4
{
    /// <summary>
    /// Interaction logic for TabelaProizvoda.xaml
    /// </summary>
    public partial class TabelaProizvoda : Window
    {
        public ObservableCollection<Product> Products
        {
            get;
            set;
        }
        public TabelaProizvoda()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void HelpBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string str = "tabelaProizvoda";
            HelpProvider.ShowHelp(str);
        }


    }

    
}
