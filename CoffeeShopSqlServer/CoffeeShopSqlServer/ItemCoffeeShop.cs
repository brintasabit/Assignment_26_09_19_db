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
    public partial class ItemCoffeeShop : Form
    {
        public ItemCoffeeShop()
        {
            InitializeComponent();
        }
        private void AddItem()
        {
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                string command = @"insert into Item values('" + nameTextBox.Text + "'," + priceTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                    string command2 = @"select * from Item where Name='" + nameTextBox.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    itemDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                sqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItem();
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            searchTextBox.Text = "";
            deleteTextBox.Text = "";
        }
        private void ShowItem()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"select * from Item";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                itemDataGridView.DataSource = dataTable;
                if (dataTable.Rows.Count > 0)
                {
                    itemDataGridView.DataSource = dataTable;
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
            ShowItem();
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            searchTextBox.Text = "";
            deleteTextBox.Text = "";

        }
    }
}
