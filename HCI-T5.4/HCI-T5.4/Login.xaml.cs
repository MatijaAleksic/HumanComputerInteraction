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

using HCI_T5._4.modeli;


namespace HCI_T5._4
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private MainWindow MainWindow { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        public Login(MainWindow window)
        {
            InitializeComponent();
            this.MainWindow = window;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Boolean uspesno = false;

            foreach (Admin admin in this.MainWindow.Administratori)
            {
                if (admin.Username.Equals(Username.Text) && admin.Password.Equals(Password.Password))
                {
                    MessageBox.Show("Uspesno ulogovan administrator!");
                    this.MainWindow.loggedUsername = Username.Text;
                    var AdminMainWindow = new HCI_T5._4.AdminMainWindow(this.MainWindow);
                    Application.Current.MainWindow = AdminMainWindow;
                    this.Close();
                    AdminMainWindow.Show();

                    uspesno = true;
                    break;
                }
            }

            foreach (Organiser organiser in this.MainWindow.Organizatori)
            {
                if (uspesno) { break; }

                if (organiser.Username.Equals(Username.Text) && organiser.Password.Equals(Password.Password))
                {
                    MessageBox.Show("Uspesno ulogovan orgranizator!");
                    this.MainWindow.loggedUsername = Username.Text;
                    var OrganiserMainWindow = new HCI_T5._4.OrganiserMainWindow(this.MainWindow);
                    Application.Current.MainWindow = OrganiserMainWindow;
                    this.Close();
                    OrganiserMainWindow.Show();
      
                    uspesno = true;
                    break;
                    

                }
            }

            foreach (Client klient in this.MainWindow.Klijenti)
            {
                if (uspesno) { break; }

                if (klient.Username.Equals(Username.Text) && klient.Password.Equals(Password.Password))
                {
                    //var clientHome = new HCI_T5._4.KlientMainWindow(this);
                    //clientHome.Show();


                    MessageBox.Show("Uspesno ulogovan klijent!");
                    this.MainWindow.loggedUsername = Username.Text;
                    var clientHome = new HCI_T5._4.KlientMainWindow(this.MainWindow);
                    Application.Current.MainWindow = clientHome;
                    this.Close();
                    clientHome.Show();
                    uspesno = true;
                    break;
                }
            }
            if (!uspesno)
            {
                MessageBox.Show("Neispravni kredencijali, pokusajte ponovo.");
            }
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            var register = new RegisterKlijent(this.MainWindow);
            register.Show();
        }

        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.MainWindow.Close();
        }

        private void HelpBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string str = "login";
            HelpProvider.ShowHelp(str);
        }
    }
}
