using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha
{
    public partial class Form1 : Form
    {
        //public static Form1 Instance = (Form1)Form1.ActiveForm;
        string root = Directory.GetCurrentDirectory();
        public static int team;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_pfp.Image = Image.FromFile(root.Replace(@"\bin\Debug", "") + @"\assets\nopfp.png");
            pb_team.Image = Image.FromFile(root.Replace(@"\bin\Debug", "") + @"\assets\noteam.png");
            lb_username.Text = "Guest";
            lb_rank.Text = "0" + " Pts.";
        }

        private void bt_off_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2() { TopLevel = false, TopMost = true };

            this.panel3.Controls.Add(form2);
            form2.Show();
        }

        public void menu_Disable()
        {
            this.bt_off.Enabled = false;
            this.bt_off.BackColor = System.Drawing.ColorTranslator.FromHtml("#726E97");
            this.bt_online.Enabled = false;
            this.bt_online.BackColor = System.Drawing.ColorTranslator.FromHtml("#726E97");
            this.bt_other.Enabled = false;
            this.bt_other.BackColor = System.Drawing.ColorTranslator.FromHtml("#726E97");
        }

        public void changeTeam(int value)
        {
            if (value == 0)
            {
                pb_team.Image = Image.FromFile(root.Replace(@"\bin\Debug", "") + @"\assets\Oicon.png");
                team = 0;
            }

            else if (value == 1)
            {
                pb_team.Image = Image.FromFile(root.Replace(@"\bin\Debug", "") + @"\assets\Xicon.png");
                team = 1;
            }
        }

        public int getTeam()
        {
            return team;
        }
    }
}
