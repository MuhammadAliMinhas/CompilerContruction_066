using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_GRADED_TASK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compiler_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            bool isValid = IsCVariableName(input);
            outputBox.Text = isValid ? "Valid C Variable Name" : "Not a valid C Variable Name";
        }

        private bool IsCVariableName(string input)
        {
            int state = 0;

            foreach (char c in input)
            {
                switch (state)
                {
                    case 0:
                        if (char.IsLetter(c) || c == '_')
                            state = 1;
                        else
                            return false;
                        break;
                    case 1:
                        if (char.IsLetterOrDigit(c) || c == '_')
                            state = 1;
                        else
                            return false;
                        break;
                    default:
                        return false;
                }
            }

            return state == 1;
        }
    }
}
