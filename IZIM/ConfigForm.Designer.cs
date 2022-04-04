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
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(22, 58);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 20);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingLabel.Location = new System.Drawing.Point(27, 24);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(69, 20);
            this.buildingLabel.TabIndex = 8;
            this.buildingLabel.Text = "Building:";
            // 
            // buildingDropdown
            // 
            this.buildingDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingDropdown.FormattingEnabled = true;
            this.buildingDropdown.Location = new System.Drawing.Point(96, 20);
            this.buildingDropdown.Name = "buildingDropdown";
            this.buildingDropdown.Size = new System.Drawing.Size(174, 28);
            this.buildingDropdown.TabIndex = 18;
            this.buildingDropdown.SelectedIndexChanged += new System.EventHandler(this.buildingDropdown_SelectedIndexChanged);
            // 
            // locationDropdown
            // 
            this.locationDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDropdown.FormattingEnabled = true;
            this.locationDropdown.Location = new System.Drawing.Point(96, 54);
            this.locationDropdown.Name = "locationDropdown";
            this.locationDropdown.Size = new System.Drawing.Size(174, 28);
            this.locationDropdown.TabIndex = 19;
            // 
            // buildingEditBtn
            // 
            this.buildingEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingEditBtn.Location = new System.Drawing.Point(275, 23);
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
            this.locationEditBtn.Location = new System.Drawing.Point(275, 57);
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
            this.addBuildingBtn.Location = new System.Drawing.Point(303, 23);
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
            this.addLocationBtn.Location = new System.Drawing.Point(303, 57);
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
            this.deleteBuildingBtn.Location = new System.Drawing.Point(331, 23);
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
            this.deleteLocationBtn.Location = new System.Drawing.Point(331, 57);
            this.deleteLocationBtn.Name = "deleteLocationBtn";
            this.deleteLocationBtn.Size = new System.Drawing.Size(26, 23);
            this.deleteLocationBtn.TabIndex = 25;
            this.deleteLocationBtn.Text = "🗑️";
            this.deleteLocationBtn.UseVisualStyleBackColor = true;
            this.deleteLocationBtn.Click += new System.EventHandler(this.deleteLocationBtn_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}