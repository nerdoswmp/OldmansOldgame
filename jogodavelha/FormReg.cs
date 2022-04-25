using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha
{
    public partial class FormReg : Form
    {
        Form1 form1 = (Form1)Form1.ActiveForm;
        int[] positions = { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        int team;
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            label1.Text = $"VS user - {rand.Next(10,5555)} Pts.";
            form1.changeTeam(rand.Next(0, 2));
            team = form1.getTeam();

            if (team == 0)
            {
                ComputerTurn();
            }

        }

        private void ComputerTurn()
        {
            string computerChar = " ";
            int computerVal = 3;
            int player = form1.getTeam();
            switch (player)
            {
                case 0:
                    computerChar = "X";
                    computerVal = 1;
                    break;
                case 1:
                    computerChar = "O";
                    computerVal = 0;
                    break;
            }

            Random rand = new Random();
            int placement = rand.Next(0, 8);
            if (positions[placement] == 3 && positions[placement] != player)
            {
                positions[placement] = computerVal;
                switch (placement)
                {
                    case 0:
                        button1.Text = computerChar;
                        button1.Enabled = false;
                        break;
                    case 1:
                        button2.Text = computerChar;
                        button2.Enabled = false;
                        break;
                    case 2:
                        button3.Text = computerChar;
                        button3.Enabled = false;
                        break;
                    case 3:
                        button4.Text = computerChar;
                        button4.Enabled = false;
                        break;
                    case 4:
                        button5.Text = computerChar;
                        button5.Enabled = false;
                        break;
                    case 5:
                        button6.Text = computerChar;
                        button6.Enabled = false;
                        break;
                    case 6:
                        button7.Text = computerChar;
                        button7.Enabled = false;
                        break;
                    case 7:
                        button8.Text = computerChar;
                        button8.Enabled = false;
                        break;
                    case 8:
                        button9.Text = computerChar;
                        button9.Enabled = false;
                        break;
                }
            }
            else
            {
                ComputerTurn();
            }

        }

        private string PlayerTurn()
        {

            switch (team)
            {
                case 0:
                    return "O";
                case 1:
                    return "X";
            }

            return " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = PlayerTurn();
            positions[0] = team;
            ComputerTurn();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = PlayerTurn();
            positions[1] = team;
            ComputerTurn();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = PlayerTurn();
            positions[2] = team;
            ComputerTurn();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = PlayerTurn();
            positions[3] = team;
            ComputerTurn();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = PlayerTurn();
            positions[4] = team;
            ComputerTurn();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = PlayerTurn();
            positions[5] = team;
            ComputerTurn();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = PlayerTurn();
            positions[6] = team;
            ComputerTurn();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = PlayerTurn();
            positions[7] = team;
            ComputerTurn();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = PlayerTurn();
            positions[8] = team;
            ComputerTurn();
            button9.Enabled = false;
        }
    }
}
