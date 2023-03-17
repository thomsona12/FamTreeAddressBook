using System;
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

namespace FamTreeAddressBookGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
        }
        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HelpWindow helpWindow = new HelpWindow();
                helpWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnHelp_Click
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddWindow addWindow = new AddWindow(contacts);
                addWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnAdd_Click
        private void btnViewTree_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FamilyTreeWindow familyTreeWindow = new FamilyTreeWindow();
                familyTreeWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnViewTree_Click
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditWindow editWindow = new EditWindow();
                editWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnEdit_Click

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } // end btnClose_Click

    }
}
