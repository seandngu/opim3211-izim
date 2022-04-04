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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
        // This is needed for the item insert form
        public static string input;
        private void RefreshInventory()
        {
            // populate inventory grid on change
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                inventoryGrid.DataSource = null;
                string query = $"SELECT Name AS Item, SUM(CASE Quantity WHEN Action = 'Scanned In' THEN Quantity WHEN Action = 'Scanned Out' THEN -1*Quantity END) Quantity ,MAX(DATE) Last_Modified FROM Logs INNER JOIN Items ON Barcode_ID = Barcode WHERE [Location] = '{locationDropdown.Text}' AND [Building] = '{buildingDropdown.Text}' GROUP BY Name HAVING SUM(Quantity) > 0";
                inventoryGrid.DataSource = cnn.Query<Inventory>(query).ToList();
                inventoryGrid.ClearSelection();
            }
        }
        // On form load, load locations for the dropdown
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // populate locations on load
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = "SELECT DISTINCT Building FROM [Locations] ORDER BY [Building]";
                buildingDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                buildingDropdown.DisplayMember = "Building";
            }
        }
        // Change the title of the form when location is changed, query the database for the grid
        private void locationDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationTitleLbl.Text = locationDropdown.Text;
            RefreshInventory();
        }
        // Insert a new item into items if needed, then add the barcode into inventory
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            string query = "";
            string action = "";
            // scan in / type barcode
            input = Interaction.InputBox("Scan/Enter a barcode."
                                        ,"Innovation Zone Inventory Management - Scan/Enter"
                                        ,"00000000");
            // do nothing if blank or default
            if (input == "00000000" || input == "")
            {
                MessageBox.Show("Scan in cancelled.");
                return;
            }
            // do the thing
            else
            {
                // is it scan in or scan out?
                DialogResult actionChoice = MessageBox.Show("Scanning in or out?"
                                                     , "Innovation Zone Inventory Management - Scan/Enter"
                                                     , MessageBoxButtons.YesNoCancel);
                // add item to inventory if nonexisting
                using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
                {
                    query = $"SELECT [Barcode_ID] FROM [Items] WHERE [Barcode_ID] = '{input}'";
                    List<Items> items = cnn.Query<Items>(query).ToList();
                    // if this list is empty, a new item needed to be added to the history
                    if (items.Count == 0)
                    {
                        // new item prompt
                        AddItemForm f = new AddItemForm();
                        f.ShowDialog();
                    }
                }
                if (actionChoice == DialogResult.Yes)
                {
                    action = "Scanned In";
                }
                else if (actionChoice == DialogResult.No)
                {
                    action = "Scanned Out";
                }
                else if (actionChoice == DialogResult.Cancel)
                {
                    return;
                }
                query = $"INSERT INTO [Logs] ([Barcode], [Building], [Location], [Action], [Date]) VALUES ('{input}', '{buildingDropdown.Text}','{locationDropdown.Text}', '{action}', DATE('now'))";
                SQLCommand.Execute(query);
                using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
                {
                    query = $"SELECT * FROM [Items] WHERE Barcode_ID = '{input}'";
                    List<Items> nameSource = cnn.Query<Items>(query).ToList();
                    string name = nameSource[0].Name.ToString();
                    MessageBox.Show($"{name} {action} of {locationTitleLbl.Text}.");
                }
                RefreshInventory();
            }
        }

        private void buildingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLCommand.LoadConnectionString()))
            {
                string query = $"SELECT [Location] FROM [Locations] WHERE [Building] = '{buildingDropdown.Text}' ORDER BY [Location]";
                locationDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                locationDropdown.DisplayMember = "Location";
            }
        }
    }
}
