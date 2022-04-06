using Dapper;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace IZIM
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        private void RefreshSelections()
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = "SELECT DISTINCT [Building] FROM [Locations] ORDER BY [Building]";
                buildingDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                buildingDropdown.DisplayMember = "Building";
            }
        }
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            // populate locations on load
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = "SELECT DISTINCT [Building] FROM [Locations] ORDER BY [Building]";
                buildingDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                buildingDropdown.DisplayMember = "Building";
            }
            // load items drop down
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = "SELECT [Name] FROM [Items]";
                nameDropdown.DataSource = cnn.Query<Items>(query).ToList();
                nameDropdown.DisplayMember = "Name";
            }
            // load category drop down
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = "SELECT DISTINCT [Category] FROM [Items]";
                categoryDropdown.DataSource = cnn.Query<Items>(query).ToList();
                categoryDropdown.DisplayMember = "Category";
            }
        }

        private void buildingEditBtn_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Edit building name:"
                            , "Innovation Zone Inventory Management - Edit Building"
                            , buildingDropdown.Text);
            string query = $"UPDATE Locations SET Building = '{input}' WHERE Building = '{buildingDropdown.Text}'; UPDATE Logs SET Building = '{input}' WHERE Building = '{buildingDropdown.Text}'";
            SQLCommand.Execute(query);
            MessageBox.Show($"{buildingDropdown.Text} changed to {input}.");
            RefreshSelections();
        }

        private void locationEditBtn_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Edit location name:"
                , "Innovation Zone Inventory Management - Edit Location"
                , locationDropdown.Text);
            string query = $"UPDATE Locations SET Location = '{input}' WHERE Location = '{locationDropdown.Text}' AND Building = '{buildingDropdown.Text}'; UPDATE Logs SET Location = '{input}' WHERE Location = '{locationDropdown.Text}' AND Building = '{buildingDropdown.Text}'";
            SQLCommand.Execute(query);
            MessageBox.Show($"{locationDropdown.Text} changed to {input}.");
            RefreshSelections();
        }

        private void addBuildingBtn_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Add building:"
                , "Innovation Zone Inventory Management - Add Building"
                , "");
            string query = $"INSERT INTO Locations (Building, Location) VALUES ('{input}', 'Placeholder')";
            if (input != "")
            {
                SQLCommand.Execute(query);
                MessageBox.Show($"{input} added.");
            }
            else
            {
                MessageBox.Show("Add building cancelled.");
            }
            RefreshSelections();
        }

        private void addLocationBtn_Click(object sender, EventArgs e)
        {
            {
                string input = Interaction.InputBox("Add location:"
                    , "Innovation Zone Inventory Management - Add Location"
                    , "");
                string queryFirst = $"DELETE FROM Locations WHERE Location = 'Placeholder' and Building = '{buildingDropdown.Text}'";
                string query = $"INSERT INTO Locations (Building, Location) VALUES ('{buildingDropdown.Text}', '{input}')";
                if (input != "")
                {
                    SQLCommand.Execute(queryFirst);
                    SQLCommand.Execute(query);
                    MessageBox.Show($"{input} added under {buildingDropdown.Text}.");
                }
                else
                {
                    MessageBox.Show("Add location cancelled.");
                }         
            }
            RefreshSelections();
        }
        private void deleteBuildingBtn_Click(object sender, EventArgs e)
        {
            {
                string input = Interaction.InputBox("To delete building, type DELETE:"
                        , "Innovation Zone Inventory Management - Delete Building"
                        , "");
                string query = $"DELETE FROM Locations WHERE Building = '{buildingDropdown.Text}'";
                if (input == "DELETE")
                { 
                    SQLCommand.Execute(query);
                    MessageBox.Show($"{buildingDropdown.Text} deleted.");
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.");
                }
                buildingDropdown.Text = "";
                locationDropdown.Text = "";
                RefreshSelections();
            }
        }

        private void deleteLocationBtn_Click(object sender, EventArgs e)
        {
            {
                string input = Interaction.InputBox("To delete location, type DELETE:"
                        , "Innovation Zone Inventory Management - Delete Location"
                        , "");
                string query = $"DELETE FROM Locations WHERE Building = '{buildingDropdown.Text}' AND Location = '{locationDropdown.Text}'";
                if (input == "DELETE")
                {
                    SQLCommand.Execute(query);
                    MessageBox.Show($"{locationDropdown.Text} deleted.");
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.");
                }
                RefreshSelections();
            }
        }

        private void barcodeText_TextChanged(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = $"SELECT * FROM [Items] WHERE [Barcode_ID] = '{barcodeText.Text}'";
                IEnumerable<Items> items = cnn.Query<Items>(query);
                // degenerate shit
                foreach (Items item in items)
                {
                    nameDropdown.Text = item.Name;
                    categoryDropdown.Text = item.Category;
                    qtyText.Text = item.Quantity.ToString();
                    priceText.Text = item.Price.ToString();
                }
            }
        }

        private void nameDropdown_TextChanged(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = $"SELECT * FROM [Items] WHERE [Name] = '{nameDropdown.Text}'";
                IEnumerable<Items> items = cnn.Query<Items>(query);
                // degenerate shit
                foreach (Items item in items)
                {
                    barcodeText.Text = item.Barcode_ID.ToString();
                    categoryDropdown.Text = item.Category;
                    qtyText.Text = item.Quantity.ToString();
                    priceText.Text = item.Price.ToString();
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE Items SET Barcode_ID = '{barcodeText.Text}', Name = '{nameDropdown.Text}', Category = '{categoryDropdown.Text}', Quantity = '{qtyText.Text}', Price = '{priceText.Text}' WHERE Barcode_ID = '{barcodeText.Text}'";
            SQLCommand.Execute(query);
            MessageBox.Show($"{nameDropdown.Text} has been updated.");
        }

        private void delitemBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleting items is not recommended. All log data associated with the item will be lost. THIS CANNOT BE UNDONE.");
            {
                string input = Interaction.InputBox("To delete the item, type DELETE:"
                        , "Innovation Zone Inventory Management - Delete item"
                        , "");
                string query = $"DELETE FROM Items WHERE Barcode_ID = '{barcodeText.Text}'; DELETE FROM Logs WHERE Barcode = '{barcodeText.Text}'";
                if (input == "DELETE")
                {
                    SQLCommand.Execute(query);
                    MessageBox.Show($"{nameDropdown.Text} has been deleted.");
                    barcodeText.Text = "";
                    categoryDropdown.Text = "";
                    nameDropdown.Text = "";
                    qtyText.Text = "";
                    priceText.Text = "";
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.");
                }
            }
        }

        private void buildingDropdown_TextChanged(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = $"SELECT [Location] FROM [Locations] WHERE [Building] = '{buildingDropdown.Text}'";
                locationDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                locationDropdown.DisplayMember = "Location";
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = directoryfBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string command = $@"/C sqlite3 -header -csv .\data\IZIMDatabase.db ""SELECT * FROM Logs;"" > {directoryfBD.SelectedPath}\export.csv";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = command;
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show($"Logs exported to {directoryfBD.SelectedPath}.");
            }
        }

        private void backupDBBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = directoryfBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string command = $@"/C copy /y .\data\IZIMDatabase.db {directoryfBD.SelectedPath}";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = command;
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show($"Database backed up to {directoryfBD.SelectedPath}.");
            }
        }

        private void importDBBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openDBOFD.ShowDialog();
            if ((result == DialogResult.OK) & (openDBOFD.FileName.Contains(".db")))
            {
                string command = $@"/C copy /y {openDBOFD.FileName} .\data\IZIMDatabase.db";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = command;
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show($"Database restored from {openDBOFD.FileName}.");
            }
        }
    }
}
