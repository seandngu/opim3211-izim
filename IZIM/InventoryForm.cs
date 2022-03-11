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
                string query = $"SELECT Name as Item, SUM(Quantity) Quantity, MAX(Date) 'Last Modified' FROM Logs INNER JOIN Items ON Barcode_ID = Barcode GROUP BY Name HAVING SUM(Quantity) > 0 AND [Location] = '{locationDropdown.Text}'";
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
                string query = "SELECT * FROM [Locations] ORDER BY [Location]";
                locationDropdown.DataSource = cnn.Query<Locations>(query).ToList();
                locationDropdown.DisplayMember = "Location";
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
                return;
            }
            // do the thing
            else
            {
                // is it scan in or scan out?
                DialogResult actionChoice = MessageBox.Show("Scanning in or out?"
                                                     , "Innovation Zone Inventory Management - Scan/Enter"
                                                     , MessageBoxButtons.YesNoCancel);
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
                // finally, add/subtract item to the log
                query = $"INSERT INTO [Logs] ([Barcode], [Location], [Action], [Date]) VALUES ('{input}', '{locationTitleLbl.Text}', '{action}', DATE('now'))";
                SQLCommand.Execute(query);
                MessageBox.Show($"{input} {action} of {locationTitleLbl.Text}."
                                ,"Innovation Zone Inventory Management - Scan/Enter");
                RefreshInventory();
            }
        }
    }
}
