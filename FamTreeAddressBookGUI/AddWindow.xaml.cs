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
using System.Windows.Shapes;

namespace FamTreeAddressBookGUI
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        List<Contact> contacts = new List<Contact>();
        public AddWindow(List<Contact> contacts)
        {
            InitializeComponent();
            this.contacts = contacts;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Contact contact = new Contact(fNameTxt.Text, lNameTxt.Text, addressTxt.Text, pCodeTxt.Text, cityTxt.Text,countryTxt.Text, provTxt.Text, emailTxt.Text, relTxt.Text, pNumTxt.Text);
                contacts.Add(contact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnAdd_Click
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } // end btnClose_Click
    }
}
