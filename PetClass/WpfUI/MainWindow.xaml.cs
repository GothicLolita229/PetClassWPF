using PetClassLibrary;
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

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /**
    * 11.21.2022
    * CSC 253
    * Lourdes Linares
    * Takes user input data, stores, displays in list box. Utilizes class library Program can switch startup projects
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Pet pet;
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTxtBox.Text;
            string type = typeTxtBox.Text;
            int age = 0;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && int.TryParse(ageTxtBox.Text, out age))
            {
                pet = new Pet(name, type, age);
            }
            else
            {
                MessageBox.Show("Please correct your input", "Invalid Input");
            }
            nameTxtBox.Text = "";
            typeTxtBox.Text = "";
            ageTxtBox.Text = "";
            
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PetListBox.Items.Add("Pet's name: " + pet.Name);
                PetListBox.Items.Add("Pet's type: " + pet.Type);
                PetListBox.Items.Add("Pet's age: " + pet.Age + "\r\n");
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Enter pet data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
