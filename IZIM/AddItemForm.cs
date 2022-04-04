using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
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
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text != string.Empty
                && categoryText.Text != string.Empty
                && qtyText.Text != string.Empty
                && priceText.Text != string.Empty)
            {
                string query = $"INSERT INTO [Items] VALUES ('{InventoryForm.input}', '{nameText.Text}', '{categoryText.Text}', '{qtyText.Text}', '{priceText.Text}')";
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
