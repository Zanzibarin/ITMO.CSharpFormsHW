using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.PAI.Lab2.Task6
{

    public partial class BiblWorm : Form
    {

        public BiblWorm()

        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BiblWorm_Load(object sender, EventArgs e)
        {

        }

        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        //Properties для Magazine

        public string title // Название
        {
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; }
        }

        public string volume // Том
        {
            get { return textBoxVolume.Text; }
            set { textBoxVolume.Text = value; }
        }

        public int number // Номер
        {
            get { return (int)numericUpDownNumber.Value; }
            set { numericUpDownNumber.Value = value; }
        }

        public int year // Год
        {
            get { return (int)numericUpDownYear.Value; }
            set { numericUpDownYear.Value = value; }
        }

        List<MyClass.Item> its = new List<MyClass.Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass.Book b = new MyClass.Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime) b.ReturnSrok();
            b.PriceBook(PeriodUse); 
            its.Add(b);
           
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber) its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (MyClass.Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        //Добавление журнала
        private void button4_Click(object sender, EventArgs e)
        {
            MyClass.Magazine b = new MyClass.Magazine(title, year, volume, number, InvNumber, Existence);
            //if (ReturnTime) b.Return();
            //b.PriceMagazine(PeriodUse);

            its.Add(b);
            title = volume = "";
            InvNumber = number = 0;
            year = 2000;
            Existence = ReturnTime = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

