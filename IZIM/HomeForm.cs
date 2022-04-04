using System;
using System.Windows.Forms;

namespace IZIM
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        // Generate the version number on load
        private void HomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                verLbl.Text = $"Version: {System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion}";
            }
            catch (Exception ex)
            {
                verLbl.Text = $"Version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
            }
            MessageBoxManager.Yes = "Scan In";
            MessageBoxManager.No = "Scan Out";
            MessageBoxManager.Register();
        }

        // Properly exit on click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Navigate to the inventory form
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryForm f = new InventoryForm();
            f.Show();
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            ConfigForm g = new ConfigForm();
            g.Show();
        }

        private void tmLbl_Click(object sender, EventArgs e)
        {
            CreditsForm h = new CreditsForm();
            h.Show();
        }
    }
}
