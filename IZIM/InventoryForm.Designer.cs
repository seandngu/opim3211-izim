namespace IZIM
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.locationTitleLbl = new System.Windows.Forms.Label();
            this.inventoryTitleLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.inventoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Location = new System.Drawing.Point(12, 155);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.Size = new System.Drawing.Size(776, 283);
            this.inventoryGrid.TabIndex = 0;
            // 
            // locationTitleLbl
            // 
            this.locationTitleLbl.AutoSize = true;
            this.locationTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.locationTitleLbl.Name = "locationTitleLbl";
            this.locationTitleLbl.Size = new System.Drawing.Size(358, 55);
            this.locationTitleLbl.TabIndex = 1;
            this.locationTitleLbl.Text = "locationTitleLbl";
            // 
            // inventoryTitleLbl
            // 
            this.inventoryTitleLbl.AutoSize = true;
            this.inventoryTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTitleLbl.Location = new System.Drawing.Point(12, 64);
            this.inventoryTitleLbl.Name = "inventoryTitleLbl";
            this.inventoryTitleLbl.Size = new System.Drawing.Size(231, 55);
            this.inventoryTitleLbl.TabIndex = 2;
            this.inventoryTitleLbl.Text = "Inventory";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(552, 27);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(78, 20);
            this.locationLbl.TabIndex = 3;
            this.locationLbl.Text = "Location: ";
            // 
            // locationDropdown
            // 
            this.locationDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(636, 27);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(121, 21);
            this.locationDropdown.TabIndex = 4;
            this.locationDropdown.SelectedIndexChanged += new System.EventHandler(this.locationDropdown_SelectedIndexChanged);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.Location = new System.Drawing.Point(552, 55);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(208, 64);
            this.inventoryBtn.TabIndex = 5;
            this.inventoryBtn.Text = "Scan/Enter Item";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.locationDropdown);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.inventoryTitleLbl);
            this.Controls.Add(this.locationTitleLbl);
            this.Controls.Add(this.inventoryGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovation Zone Inventory Management - Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGrid;
        private System.Windows.Forms.Label locationTitleLbl;
        private System.Windows.Forms.Label inventoryTitleLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox locationDropdown;
        private System.Windows.Forms.Button inventoryBtn;
    }
}