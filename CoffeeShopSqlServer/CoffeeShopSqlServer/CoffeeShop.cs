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
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }
        private void AddInfo()
        {
            try
            {
                if (itemComboBox.Text == "Hot")
                {
                    int totalPrice = Convert.ToInt32(quantityTextBox.Text) * 120;

                    string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                    SqlConnection sqlConn = new SqlConnection(conn);
                    string command = @"insert into Customer (Name,Contact,Address,Item,Quantity,Price) values ('" + customerNameTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','" + itemComboBox.Text + "'," + quantityTextBox.Text + ","+totalPrice+")";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);

                    sqlConn.Open();
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {

                        MessageBox.Show("Saved");
                        string command2 = @"select * from Customer where Name='" + customerNameTextBox.Text + "'";
                        SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        purchaseDataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    sqlConn.Close();
                }
                else if (itemComboBox.Text == "Cold")
                {
                    int totalPrice = Convert.ToInt32(quantityTextBox.Text) * 100;

                    string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                    SqlConnection sqlConn = new SqlConnection(conn);
                    string command = @"insert into Customer (Name,Contact,Address,Item,Quantity,Price) values ('" + customerNameTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','" + itemComboBox.Text + "'," + quantityTextBox.Text + "," + totalPrice + ")";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);

                    sqlConn.Open();
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {

                        MessageBox.Show("Saved");
                        string command2 = @"select * from Customer where Name='" + customerNameTextBox.Text + "'";
                        SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        purchaseDataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    sqlConn.Close();
                }
                else if (itemComboBox.Text == "Black")
                {
                    int totalPrice = Convert.ToInt32(quantityTextBox.Text) * 90;

                    string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                    SqlConnection sqlConn = new SqlConnection(conn);
                    string command = @"insert into Customer (Name,Contact,Address,Item,Quantity,Price) values ('" + customerNameTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','" + itemComboBox.Text + "'," + quantityTextBox.Text + "," + totalPrice + ")";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);

                    sqlConn.Open();
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {

                        MessageBox.Show("Saved");
                        string command2 = @"select * from Customer where Name='" + customerNameTextBox.Text + "'";
                        SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        purchaseDataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    sqlConn.Close();
                }
                else if (itemComboBox.Text == "Regular")
                {
                    int totalPrice = Convert.ToInt32(quantityTextBox.Text) * 80;

                    string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                    SqlConnection sqlConn = new SqlConnection(conn);
                    string command = @"insert into Customer (Name,Contact,Address,Item,Quantity,Price) values ('" + customerNameTextBox.Text + "','" + contactTextBox.Text + "','" + addressTextBox.Text + "','" + itemComboBox.Text + "'," + quantityTextBox.Text + "," + totalPrice + ")";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);

                    sqlConn.Open();
                    int isexecuted = sqlCommand.ExecuteNonQuery();
                    if (isexecuted > 0)
                    {

                        MessageBox.Show("Saved");
                        string command2 = @"select * from Customer where Name='" + customerNameTextBox.Text + "'";
                        SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        purchaseDataGridView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    sqlConn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddInfo();
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = "";
            searchTextBox.Text = "";
        }
        private void ShowInfo()
        {
            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Customer";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count>0)
            {
                purchaseDataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            sqlConn.Close();
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowInfo();
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = "";
            searchTextBox.Text = "";
        }
        private void SearchInfo()
        {
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                string command = @"select * from Customer where ID=" + searchTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    purchaseDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                sqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchInfo();
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = "";
            searchTextBox.Text = "";
        }
        private void UpdateInfo()
        {
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                string command = @"update Customer set Name='"+customerNameTextBox.Text+"',Contact='"+contactTextBox.Text+"',Address='"+addressTextBox.Text+"',Item='"+itemComboBox.Text+"',Quantity="+quantityTextBox.Text+" where ID="+searchTextBox.Text+"";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    string command2 = @"select * from Customer where Name='" + customerNameTextBox.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    purchaseDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Can Not Update");
                }
                sqlConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
           // purchaseDataGridView = "";
            UpdateInfo();
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = "";
            searchTextBox.Text = "";
        }
        private void DeleteInfo()
        {
            try
            {
                string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
                SqlConnection sqlConn = new SqlConnection(conn);
                string command = @"delete from Customer where ID=" + searchTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                sqlConn.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Information Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error While Trying To Remove");
                }
                sqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteInfo();
            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            itemComboBox.Text = "Select An Item";
            quantityTextBox.Text = "";
            searchTextBox.Text = "";
        }
    }
}
