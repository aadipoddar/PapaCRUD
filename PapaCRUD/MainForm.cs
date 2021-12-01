using System.Data;
using System.Data.SqlClient;

namespace PapaCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PapaCRUD;Integrated Security=True");
        private void inserButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Details (ItemName , Design , Color) VALUES (@itemName, @design, @color)", con);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@itemName", itemNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@design", designTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@color", colorComboBox.Text);

                try
                {
                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    con.Close();
                }
            }

            BindData();

            ClearForm();
        }

        private void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Details", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Details SET ItemName = @itemName, Design = @design , Color = @color WHERE ProductId = @ID", con);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ID", int.Parse(productIdTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@itemName", itemNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@design", designTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@color", colorComboBox.Text);

                try
                {
                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    con.Close();
                }
            }

            BindData();

            ClearForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool validateProductId = productIdTextBox.Text == "";
            if (!validateProductId)
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE Details WHERE ProductId = @ID", con);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@ID", int.Parse(productIdTextBox.Text));

                try
                {
                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    con.Close();
                } 
            }

            else
            {
                MessageBox.Show("Product ID required, Select One From Dat Grid");
            }

            BindData();

            ClearForm();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTextBox.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            itemNameTextBox.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            designTextBox.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            colorComboBox.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ClearForm()
        {
            productIdTextBox.Text = string.Empty;
            itemNameTextBox.Text = string.Empty;
            designTextBox.Text = string.Empty;
            colorComboBox.Text = string.Empty;
        }

        private bool Validation()
        {
            if (itemNameTextBox.Text == "")
            {
                MessageBox.Show("Item Name Required");
                return false;
            }

            if (designTextBox.Text == "")
            {
                MessageBox.Show("Design Required");
                return false;
            }

            if (colorComboBox.Text == "")
            {
                MessageBox.Show("Color Required");
                return false;
            }

            return true;
        }
    }
}