using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSqlServer
{
    public partial class OrderCoffeeShop : Form
    {
        public OrderCoffeeShop()
        {
            InitializeComponent();
        }
        private void AddOrder()
        {
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                string command = @"insert into OrderItem values('" + nameTextBox.Text + "',"+quantityTextBox.Text+"," + totalPriceTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                    string command2 = @"select * from OrderItem where Name='" + nameTextBox.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    orderDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                sqlConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddOrder();
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPriceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
        private void ShowOrder()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"select * from OrderItem";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                orderDataGridView.DataSource = dataTable;
                if (dataTable.Rows.Count > 0)
                {
                    orderDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowOrder();
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPriceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
        private void SearchOrder()
        {

            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"select * from OrderItem where Name='" + searchTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    orderDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchOrder();
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPriceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
        private void UpdateOrder()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"update OrderItem set Name='" + nameTextBox.Text + "',Quantity="+quantityTextBox.Text+",Total_Price=" + totalPriceTextBox.Text + " where ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                string command2 = @"select * from OrderItem where ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Order Updated!");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    orderDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Can Not Update Order!");
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateOrder();
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPriceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
        private void DeleteOrder()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"delete from OrderItem where ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Information Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error While Trying To Remove");
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOrder();
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPriceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
    }
}
