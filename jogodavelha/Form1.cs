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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var root = Directory.GetCurrentDirectory();
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
    }
}
