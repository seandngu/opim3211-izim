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
        }

        private void buildingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = $"SELECT [Location] FROM [Locations] WHERE [Building] = '{buildingDropdown.Text}'";
                locationDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                locationDropdown.DisplayMember = "Location";
            }
        }

        private void buildingEditBtn_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Edit building name:"
                            , "Innovation Zone Inventory Management - Edit Building"
                            , buildingDropdown.Text);
            string query = $"UPDATE Locations SET Building = '{input}' WHERE Building = '{buildingDropdown.Text}'";
            SQLCommand.Execute(query);
            MessageBox.Show($"{buildingDropdown.Text} changed to {input}.");
            RefreshSelections();
        }

        private void locationEditBtn_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Edit location name:"
                , "Innovation Zone Inventory Management - Edit Location"
                , locationDropdown.Text);
            string query = $"UPDATE Locations SET Location = '{input}' WHERE Location = '{locationDropdown.Text}' AND Building = '{buildingDropdown.Text}'";
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
    }
}
