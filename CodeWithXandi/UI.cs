using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWithXandi
{
    public partial class UI : Form
    {
        Random rd = new Random();
        int ComputersGuess;

        public UI()
        {
            InitializeComponent();
        }

        private void InputGuess_Click(object sender, EventArgs e)
        {
            // check that the input from text box is a number
            int Result;

            // if input is a number
            if (int.TryParse(UserInput.Text, out Result))
            {
                if (Convert.ToInt32(UserInput.Text) > ComputersGuess)
                {
                    ComputerResponse.Text = "Too High!";
                }

                else if (Convert.ToInt32(UserInput.Text) < ComputersGuess)
                {
                    ComputerResponse.Text = ("Too Low!");
                }

                else
                {
                   ComputerResponse.Text = "Correct!";

                    // end game.
                    StartGame.Enabled = true;
                    InputGuess.Hide();
                    label1.Hide();
                    UserInput.Hide();

                }
            }

            // if input isn't a number
            else
            {
                ComputerResponse.Text = "That Not a Number";
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            ComputerResponse.Text = "";
            StartGame.Enabled = false;
            InputGuess.Show();
            label1.Show();
            UserInput.Show();

            ComputersGuess = rd.Next(0, 11);

        }
    }
}
