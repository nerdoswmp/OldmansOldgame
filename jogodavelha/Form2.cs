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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_regular_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg() { TopLevel = false };
            Form1 form1 = (Form1)Form1.ActiveForm;
            formReg.Parent = form1.panel3;
            formReg.Show();
            bt_regular.Enabled = false;
            form1.menu_Disable();
            this.Hide();
        }
    }
}
