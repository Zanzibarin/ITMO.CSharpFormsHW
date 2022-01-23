using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.PAI.Lab2.Task2
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (PeopleList.Text.Length != 0)
            {
                MemberList.Items.Add(PeopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            while (MemberList.CheckedIndices.Count > 0)
            MemberList.Items.RemoveAt(MemberList.CheckedIndices[0]);

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            MemberList.Sorted = true;
        }
    }
}
