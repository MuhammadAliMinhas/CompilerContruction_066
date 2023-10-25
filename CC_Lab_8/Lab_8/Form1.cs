using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
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
            string state = "q0";

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                state = Transition(state, symbol);
            }

            if (state == "q4")
            {
                outputBox.Text = "Accepted";
            }
            else
            {
                outputBox.Text = "Rejected";
            }
        }

        private string Transition(string currentState, char inputSymbol)
        {
            switch (currentState)
            {
                case "q0":
                    if (inputSymbol == 'a')
                        return "q1";
                    break;
                case "q1":
                    if (inputSymbol == 'b')
                        return "q2";
                    break;
                case "q2":
                    if (inputSymbol == 'c')
                        return "q3";
                    break;
                case "q3":
                    if (inputSymbol == 'c')
                        return "q4";
                    break;
            }

            // If no transition is defined, return an error state
            return "qe";
        }
    }
}
