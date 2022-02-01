using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject_SQL
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Orders;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int Id = 0;
        
	public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Orders", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Очистка окна ввода
        private void ClearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxHouseNameShort.Text = "";
            textBoxOrderTextShort.Text = "";
            textBoxOrderURL.Text = "";
            textBoxDeliveryDate.Text = "";
            //ID = 0;
        }

        // Добавление записи
		private void btn_Insert_Click(object sender, EventArgs e)
		{
            if (textBoxFirstName.Text != "" && 
                textBoxLastName.Text != "" && 
                textBoxHouseNameShort.Text != "" && 
                textBoxOrderTextShort.Text != "")
            {
                cmd = new SqlCommand("insert into Orders(FirstName, LastName, HouseNameShort, OrderTextShort, OrderURL, DeliveryDate) values(@FirstName, @LastName, @HouseNameShort, @OrderTextShort, @OrderURL, @DeliveryDate)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@HouseNameShort", textBoxHouseNameShort.Text);
                cmd.Parameters.AddWithValue("@OrderTextShort", textBoxOrderTextShort.Text);
                cmd.Parameters.AddWithValue("@OrderURL", textBoxOrderURL.Text);
                cmd.Parameters.AddWithValue("@DeliveryDate", Convert.ToDateTime(textBoxDeliveryDate.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Новая запись добавлена");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxHouseNameShort.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxOrderTextShort.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            textBoxOrderURL.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
            textBoxDeliveryDate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
     
        }

        // обновление записи
		private void btn_Update_Click(object sender, EventArgs e)
		{
            if (textBoxFirstName.Text != "" &&
                textBoxLastName.Text != "" &&
                textBoxHouseNameShort.Text != "" &&
                textBoxOrderTextShort.Text != "")
            {
                cmd = new SqlCommand(
                    "update Orders set " +
                    "FirstName=@FirstName, " +
                    "LastName=@LastName, " +
                    "HouseNameShort=@HouseNameShort, " +
                    "OrderTextShort=@OrderTextShort, " +
                    "OrderURL=@OrderURL, " +
                    "DeliveryDate=@DeliveryDate " +
                    "where Id=@Id", con);


                con.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@HouseNameShort", textBoxHouseNameShort.Text);
                cmd.Parameters.AddWithValue("@OrderTextShort", textBoxOrderTextShort.Text);
                cmd.Parameters.AddWithValue("@OrderURL", textBoxOrderURL.Text);
                cmd.Parameters.AddWithValue("@DeliveryDate", Convert.ToDateTime(textBoxDeliveryDate.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно обновлена");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Выделите строку, которую хотите обновить");
            }
        }

		private void btn_Delete_Click(object sender, EventArgs e)
		{
            if (Id != 0)
            {
                cmd = new SqlCommand("delete Orders where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Запись успешно удалена");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Выделите запись для удаления");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
