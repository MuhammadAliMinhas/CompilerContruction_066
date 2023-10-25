using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string uppercaseAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialCharacters = "!@#$%^&*()_+[]{}|;:,.<>?";

            // Initials of first and last name
            string firstName = "M";
            string lastName = "Ali Minhas";

            // Generate random numbers that start with 066
            Random random = new Random();
            string randomNumbers = "066" + random.Next(1000, 10000).ToString();

            // Generate random uppercase alphabet
            char randomUppercase = uppercaseAlphabets[random.Next(0, uppercaseAlphabets.Length)];

            // Generate two random special characters
            char specialChar1 = specialCharacters[random.Next(0, specialCharacters.Length)];
            char specialChar2 = specialCharacters[random.Next(0, specialCharacters.Length)];

            // Combine the generated components
            string password = randomUppercase + firstName + lastName + randomNumbers + specialChar1 + specialChar2;

            // Shuffle the password for randomness
            password = new string(password.ToCharArray().OrderBy(x => random.Next()).ToArray());

            // Ensure the password length is not more than 16 characters
            if (password.Length > 16)
            {
                password = password.Substring(0, 16);
            }

            generatedPassword.Text = password;
        }
    }
}
