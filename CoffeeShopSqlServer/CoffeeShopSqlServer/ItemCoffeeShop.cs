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
                string command = @"insert into Item (Name,Price) values('" + nameTextBox.Text + "'," + priceTextBox.Text + ")";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                
                sqlConn.Open();
                
                int executed = sqlCommand.ExecuteNonQuery();
                if (executed > 0)
                {

                        MessageBox.Show("Saved");
                        string command2 = @"select * from Item where Name like '" + nameTextBox.Text + "'";
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
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                /* string command1 = @"select * from Item where Name like '" + nameTextBox.Text + "'";
                 SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConn);
                 sqlConn.Open();
                 int isExecuted = (int)sqlCommand1.ExecuteScalar();
                 if (isExecuted > 0)
                 {
                     MessageBox.Show("Item Name Already Exists");
                     nameTextBox.Text = "";
                     priceTextBox.Text = "";
                     searchTextBox.Text = "";
                     idTextBox.Text = "";
                     sqlConn.Close();

                 }
                 else
                 {

                     AddItem();
                     nameTextBox.Text = "";
                     priceTextBox.Text = "";
                     searchTextBox.Text = "";
                     idTextBox.Text = "";
                 }
                 */
               
                string command = @"select * from Item where Name='" + nameTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    // itemDataGridView.DataSource = dataTable;
                    MessageBox.Show("Item Name Exists");
                    nameTextBox.Text = "";
                    priceTextBox.Text = "";
                    searchTextBox.Text = "";
                    idTextBox.Text = "";
                }
                else
                {
                    AddItem();
                    nameTextBox.Text = "";
                    priceTextBox.Text = "";
                    searchTextBox.Text = "";
                    idTextBox.Text = "";
                }
                sqlConn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
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
            idTextBox.Text = "";

        }
        private void SearchItem()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"select * from Item where Name='" + searchTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchItem();
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }

        private void UpdateItem()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"update Item set Name='" + nameTextBox.Text + "',Price=" + priceTextBox.Text + " where ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                string command2 = @"select * from Item where ID=" + idTextBox.Text + "";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Item Updated!");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    itemDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Can Not Update Item!");
                }

                sqlConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateItem();
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            searchTextBox.Text = "";
            idTextBox.Text = "";
        }
        private void DeleteItem()
        {
            try
            {
                string sqlConn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(sqlConn);
                string command = @"delete from Item where ID="+idTextBox.Text+"";
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
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
    }
}
