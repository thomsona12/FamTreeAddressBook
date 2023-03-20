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
using System.Xml.Linq;

namespace FamTreeAddressBookGUI
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Contact contact;
        public static bool IsOpen { get; private set; }
        public EditWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            fNameTxt.Text = this.contact.firstName;
            lNameTxt.Text = this.contact.lastName;
            addressTxt.Text = this.contact.address;
            pCodeTxt.Text = this.contact.postalCode;
            cityTxt.Text = this.contact.city;
            countryTxt.Text = this.contact.country;
            provTxt.Text = this.contact.province;
            emailTxt.Text = this.contact.email;
            relTxt.Text = this.contact.relationship;
            pNumTxt.Text = this.contact.phoneNumber;
        }
        
        //figure out how to trigger event
        private void onLoadEvent(object sender, RoutedEventArgs e)
        {
            IsOpen = true;
        }

        private void onUnLoadEvent(object sender, RoutedEventArgs e)
        {
            IsOpen = false;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contact c = new Contact(fNameTxt.Text, lNameTxt.Text, addressTxt.Text, pCodeTxt.Text, cityTxt.Text, countryTxt.Text, provTxt.Text, emailTxt.Text, relTxt.Text, pNumTxt.Text);
                this.contact = c;
                //int temp = ((MainWindow)Application.Current.MainWindow).lstContacts.Items.Count;
                //figure out the error with reopening window
                ((MainWindow)Application.Current.MainWindow).lstContacts.Items.Insert(((MainWindow)Application.Current.MainWindow).lstContacts.Items.Count-1,this.contact);
                ((MainWindow)Application.Current.MainWindow).lstContacts.SelectedItem= this.contact;
                ((MainWindow)Application.Current.MainWindow).lstContacts.Items.RemoveAt(((MainWindow)Application.Current.MainWindow).lstContacts.Items.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnUpdate_Click

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end btnDelete_Click
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } // end btnClose_Click
    }
}
