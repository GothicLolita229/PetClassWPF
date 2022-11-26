using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetClassLibrary;

/**
* 11.21.2022
* CSC 253
* Lourdes Linares
* Takes user input data, stores, displays in list box. Utilizes class library 
*/

namespace WinUI
{
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
        }

        Pet pet;
        private void Enterbtn_Click(object sender, EventArgs e)
        {
            string name = petNameBox.Text;
            string type = petTypeBox.Text;
            int age = 0;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && int.TryParse(petAgeBox.Text, out age))
            {
                pet = new Pet(name, type, age);
            }
            else 
            {
                MessageBox.Show("Please correct your input", "Invalid Input");
            }
            petNameBox.Text = "";
            petTypeBox.Text = "";
            petAgeBox.Text = "";
        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.Add("Pet's name: " + pet.Name);
                listBox.Items.Add("Pet's type: " + pet.Type);
                listBox.Items.Add("Pet's age: " + pet.Age);
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
