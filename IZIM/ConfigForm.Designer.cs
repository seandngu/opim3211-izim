namespace IZIM
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.locationLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.buildingDropdown = new System.Windows.Forms.ComboBox();
            this.locationDropdown = new System.Windows.Forms.ComboBox();
            this.buildingEditBtn = new System.Windows.Forms.Button();
            this.locationEditBtn = new System.Windows.Forms.Button();
            this.addBuildingBtn = new System.Windows.Forms.Button();
            this.addLocationBtn = new System.Windows.Forms.Button();
            this.deleteBuildingBtn = new System.Windows.Forms.Button();
            this.deleteLocationBtn = new System.Windows.Forms.Button();
            this.categoryDropdown = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.priceText = new System.Windows.Forms.TextBox();
            this.qtyText = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildLocConfigLbl = new System.Windows.Forms.Label();
            this.itemConfigLbl = new System.Windows.Forms.Label();
            this.delitemBtn = new System.Windows.Forms.Button();
            this.nameDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importDBBtn = new System.Windows.Forms.Button();
            this.backupDBBtn = new System.Windows.Forms.Button();
            this.directoryfBD = new System.Windows.Forms.FolderBrowserDialog();
            this.openDBOFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(22, 74);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 20);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingLabel.Location = new System.Drawing.Point(27, 40);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(69, 20);
            this.buildingLabel.TabIndex = 8;
            this.buildingLabel.Text = "Building:";
            // 
            // buildingDropdown
            // 
            this.buildingDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingDropdown.FormattingEnabled = true;
            this.buildingDropdown.Location = new System.Drawing.Point(96, 36);
            this.buildingDropdown.Name = "buildingDropdown";
            this.buildingDropdown.Size = new System.Drawing.Size(174, 28);
            this.buildingDropdown.TabIndex = 18;
            this.buildingDropdown.TextChanged += new System.EventHandler(this.buildingDropdown_TextChanged);
            // 
            // locationDropdown
            // 
            this.locationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(96, 70);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(174, 28);
            this.locationDropdown.TabIndex = 19;
            // 
            // buildingEditBtn
            // 
            this.buildingEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingEditBtn.Location = new System.Drawing.Point(275, 39);
            this.buildingEditBtn.Name = "buildingEditBtn";
            this.buildingEditBtn.Size = new System.Drawing.Size(26, 23);
            this.buildingEditBtn.TabIndex = 20;
            this.buildingEditBtn.Text = "✎";
            this.buildingEditBtn.UseVisualStyleBackColor = true;
            this.buildingEditBtn.Click += new System.EventHandler(this.buildingEditBtn_Click);
            // 
            // locationEditBtn
            // 
            this.locationEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationEditBtn.Location = new System.Drawing.Point(275, 73);
            this.locationEditBtn.Name = "locationEditBtn";
            this.locationEditBtn.Size = new System.Drawing.Size(26, 23);
            this.locationEditBtn.TabIndex = 21;
            this.locationEditBtn.Text = "✎";
            this.locationEditBtn.UseVisualStyleBackColor = true;
            this.locationEditBtn.Click += new System.EventHandler(this.locationEditBtn_Click);
            // 
            // addBuildingBtn
            // 
            this.addBuildingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBuildingBtn.Location = new System.Drawing.Point(303, 39);
            this.addBuildingBtn.Name = "addBuildingBtn";
            this.addBuildingBtn.Size = new System.Drawing.Size(26, 23);
            this.addBuildingBtn.TabIndex = 22;
            this.addBuildingBtn.Text = "+";
            this.addBuildingBtn.UseVisualStyleBackColor = true;
            this.addBuildingBtn.Click += new System.EventHandler(this.addBuildingBtn_Click);
            // 
            // addLocationBtn
            // 
            this.addLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLocationBtn.Location = new System.Drawing.Point(303, 73);
            this.addLocationBtn.Name = "addLocationBtn";
            this.addLocationBtn.Size = new System.Drawing.Size(26, 23);
            this.addLocationBtn.TabIndex = 23;
            this.addLocationBtn.Text = "+";
            this.addLocationBtn.UseVisualStyleBackColor = true;
            this.addLocationBtn.Click += new System.EventHandler(this.addLocationBtn_Click);
            // 
            // deleteBuildingBtn
            // 
            this.deleteBuildingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBuildingBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBuildingBtn.Location = new System.Drawing.Point(331, 39);
            this.deleteBuildingBtn.Name = "deleteBuildingBtn";
            this.deleteBuildingBtn.Size = new System.Drawing.Size(26, 23);
            this.deleteBuildingBtn.TabIndex = 24;
            this.deleteBuildingBtn.Text = "🗑️";
            this.deleteBuildingBtn.UseVisualStyleBackColor = true;
            this.deleteBuildingBtn.Click += new System.EventHandler(this.deleteBuildingBtn_Click);
            // 
            // deleteLocationBtn
            // 
            this.deleteLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLocationBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteLocationBtn.Location = new System.Drawing.Point(331, 73);
            this.deleteLocationBtn.Name = "deleteLocationBtn";
            this.deleteLocationBtn.Size = new System.Drawing.Size(26, 23);
            this.deleteLocationBtn.TabIndex = 25;
            this.deleteLocationBtn.Text = "🗑️";
            this.deleteLocationBtn.UseVisualStyleBackColor = true;
            this.deleteLocationBtn.Click += new System.EventHandler(this.deleteLocationBtn_Click);
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDropdown.FormattingEnabled = true;
            this.categoryDropdown.Location = new System.Drawing.Point(132, 200);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(182, 28);
            this.categoryDropdown.TabIndex = 36;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(137, 301);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(117, 23);
            this.submitBtn.TabIndex = 33;
            this.submitBtn.Text = "Apply Changes";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(132, 263);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(182, 26);
            this.priceText.TabIndex = 32;
            // 
            // qtyText
            // 
            this.qtyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyText.Location = new System.Drawing.Point(132, 232);
            this.qtyText.Name = "qtyText";
            this.qtyText.Size = new System.Drawing.Size(182, 26);
            this.qtyText.TabIndex = 31;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(82, 263);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 29;
            this.priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(58, 233);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 20);
            this.quantityLabel.TabIndex = 28;
            this.quantityLabel.Text = "Quantity:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(53, 203);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 20);
            this.categoryLabel.TabIndex = 27;
            this.categoryLabel.Text = "Category:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(75, 173);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Name:";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(132, 140);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(182, 26);
            this.barcodeText.TabIndex = 37;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Barcode:";
            // 
            // buildLocConfigLbl
            // 
            this.buildLocConfigLbl.AutoSize = true;
            this.buildLocConfigLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildLocConfigLbl.Location = new System.Drawing.Point(12, 10);
            this.buildLocConfigLbl.Name = "buildLocConfigLbl";
            this.buildLocConfigLbl.Size = new System.Drawing.Size(260, 20);
            this.buildLocConfigLbl.TabIndex = 39;
            this.buildLocConfigLbl.Text = "Building/Location Configuration";
            // 
            // itemConfigLbl
            // 
            this.itemConfigLbl.AutoSize = true;
            this.itemConfigLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemConfigLbl.Location = new System.Drawing.Point(12, 114);
            this.itemConfigLbl.Name = "itemConfigLbl";
            this.itemConfigLbl.Size = new System.Drawing.Size(158, 20);
            this.itemConfigLbl.TabIndex = 40;
            this.itemConfigLbl.Text = "Item Configuration";
            // 
            // delitemBtn
            // 
            this.delitemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delitemBtn.ForeColor = System.Drawing.Color.Red;
            this.delitemBtn.Location = new System.Drawing.Point(319, 172);
            this.delitemBtn.Name = "delitemBtn";
            this.delitemBtn.Size = new System.Drawing.Size(26, 23);
            this.delitemBtn.TabIndex = 41;
            this.delitemBtn.Text = "🗑️";
            this.delitemBtn.UseVisualStyleBackColor = true;
            this.delitemBtn.Click += new System.EventHandler(this.delitemBtn_Click);
            // 
            // nameDropdown
            // 
            this.nameDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDropdown.FormattingEnabled = true;
            this.nameDropdown.Location = new System.Drawing.Point(132, 169);
            this.nameDropdown.Name = "nameDropdown";
            this.nameDropdown.Size = new System.Drawing.Size(182, 28);
            this.nameDropdown.TabIndex = 42;
            this.nameDropdown.TextChanged += new System.EventHandler(this.nameDropdown_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Data Management";
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(14, 361);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(117, 23);
            this.exportBtn.TabIndex = 44;
            this.exportBtn.Text = "Export Logs";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importDBBtn
            // 
            this.importDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importDBBtn.Location = new System.Drawing.Point(137, 361);
            this.importDBBtn.Name = "importDBBtn";
            this.importDBBtn.Size = new System.Drawing.Size(117, 23);
            this.importDBBtn.TabIndex = 45;
            this.importDBBtn.Text = "Import DB";
            this.importDBBtn.UseVisualStyleBackColor = true;
            this.importDBBtn.Click += new System.EventHandler(this.importDBBtn_Click);
            // 
            // backupDBBtn
            // 
            this.backupDBBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupDBBtn.Location = new System.Drawing.Point(260, 361);
            this.backupDBBtn.Name = "backupDBBtn";
            this.backupDBBtn.Size = new System.Drawing.Size(117, 23);
            this.backupDBBtn.TabIndex = 46;
            this.backupDBBtn.Text = "Backup DB";
            this.backupDBBtn.UseVisualStyleBackColor = true;
            this.backupDBBtn.Click += new System.EventHandler(this.backupDBBtn_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 396);
            this.Controls.Add(this.backupDBBtn);
            this.Controls.Add(this.importDBBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameDropdown);
            this.Controls.Add(this.delitemBtn);
            this.Controls.Add(this.itemConfigLbl);
            this.Controls.Add(this.buildLocConfigLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.categoryDropdown);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.qtyText);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteLocationBtn);
            this.Controls.Add(this.deleteBuildingBtn);
            this.Controls.Add(this.addLocationBtn);
            this.Controls.Add(this.addBuildingBtn);
            this.Controls.Add(this.locationEditBtn);
            this.Controls.Add(this.buildingEditBtn);
            this.Controls.Add(this.locationDropdown);
            this.Controls.Add(this.buildingDropdown);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.buildingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovation Zone Inventory Management - Configuration Menu";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.ComboBox buildingDropdown;
        private System.Windows.Forms.ComboBox locationDropdown;
        private System.Windows.Forms.Button buildingEditBtn;
        private System.Windows.Forms.Button locationEditBtn;
        private System.Windows.Forms.Button addBuildingBtn;
        private System.Windows.Forms.Button addLocationBtn;
        private System.Windows.Forms.Button deleteBuildingBtn;
        private System.Windows.Forms.Button deleteLocationBtn;
        private System.Windows.Forms.ComboBox categoryDropdown;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox qtyText;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label buildLocConfigLbl;
        private System.Windows.Forms.Label itemConfigLbl;
        private System.Windows.Forms.Button delitemBtn;
        private System.Windows.Forms.ComboBox nameDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importDBBtn;
        private System.Windows.Forms.Button backupDBBtn;
        private System.Windows.Forms.FolderBrowserDialog directoryfBD;
        private System.Windows.Forms.OpenFileDialog openDBOFD;
    }
}