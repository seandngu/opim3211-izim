using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace IZIM
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            barcodeLbl.Text = InventoryForm.input;
            {
                string query = $"SELECT DISTINCT [Category] FROM Items";
                using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
                {
                    cnn.Execute(query);
                    categoryDropdown.DataSource = cnn.Query<Items>(query).ToList();
                    categoryDropdown.DisplayMember = "Category";
                }
            }
        }


        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text != string.Empty
                && categoryDropdown.Text != string.Empty
                && qtyText.Text != string.Empty
                && priceText.Text != string.Empty)
            {
                string query = $"INSERT INTO [Items] VALUES ('{InventoryForm.input}', '{nameText.Text}', '{categoryDropdown.Text}', '{qtyText.Text}', '{priceText.Text}')";
                using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
                {
                    cnn.Execute(query);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Submission cancelled.");
            }
        }
    }
}
