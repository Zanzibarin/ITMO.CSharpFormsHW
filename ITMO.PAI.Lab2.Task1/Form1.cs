using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.PAI.Lab2.Task1
{
    public partial class WinQuestion : Form
    {
        public WinQuestion()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что вы так думаете!");
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {

        }

        private void BtnNo_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnNo_MouseMove(object sender, MouseEventArgs e)
        {
            BtnNo.Top -= e.Y;
            BtnNo.Left += e.X;
            if (BtnNo.Top < -10 || BtnNo.Top > 100)
                BtnNo.Top = 60;
            if (BtnNo.Left < -80 || BtnNo.Left > 250)
                BtnNo.Left = 120;
        }
    }
}
