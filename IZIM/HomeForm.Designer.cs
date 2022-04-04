namespace IZIM
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.tmLbl = new System.Windows.Forms.Label();
            this.verLbl = new System.Windows.Forms.Label();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerPictureBox
            // 
            this.bannerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPictureBox.BackgroundImage")));
            this.bannerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bannerPictureBox.Location = new System.Drawing.Point(12, 12);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(449, 170);
            this.bannerPictureBox.TabIndex = 0;
            this.bannerPictureBox.TabStop = false;
            // 
            // tmLbl
            // 
            this.tmLbl.AutoSize = true;
            this.tmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmLbl.Location = new System.Drawing.Point(263, 428);
            this.tmLbl.Name = "tmLbl";
            this.tmLbl.Size = new System.Drawing.Size(198, 13);
            this.tmLbl.TabIndex = 1;
            this.tmLbl.Text = "Developed by OPIM 3211 Team 4";
            this.tmLbl.Click += new System.EventHandler(this.tmLbl_Click);
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLbl.Location = new System.Drawing.Point(12, 428);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(93, 13);
            this.verLbl.TabIndex = 2;
            this.verLbl.Text = "Version 0.0.0.0";
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.Location = new System.Drawing.Point(132, 165);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(208, 64);
            this.inventoryBtn.TabIndex = 3;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBtn.Location = new System.Drawing.Point(132, 235);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(208, 64);
            this.configBtn.TabIndex = 4;
            this.configBtn.Text = "Configuration";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(132, 305);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(208, 64);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.configBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.verLbl);
            this.Controls.Add(this.tmLbl);
            this.Controls.Add(this.bannerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovation Zone Inventory Management - Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.Button loadPersonNameBtn;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Button loadNameButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.PictureBox bannerPictureBox;
        private System.Windows.Forms.Label tmLbl;
        private System.Windows.Forms.Label verLbl;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

