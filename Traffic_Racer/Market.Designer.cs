namespace Traffic_Racer
{
    partial class Market
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            this.pictureBox_Ford = new System.Windows.Forms.PictureBox();
            this.pictureBox_Coop = new System.Windows.Forms.PictureBox();
            this.pictureBox_Truck = new System.Windows.Forms.PictureBox();
            this.label_satinAlTruck = new System.Windows.Forms.Label();
            this.label_satinAlCoop = new System.Windows.Forms.Label();
            this.label_satinAlFord = new System.Windows.Forms.Label();
            this.label_Ford = new System.Windows.Forms.Label();
            this.label_Coop = new System.Windows.Forms.Label();
            this.label_Truck = new System.Windows.Forms.Label();
            this.satinAlinanKontrol = new System.Windows.Forms.Timer(this.components);
            this.label_para = new System.Windows.Forms.Label();
            this.label_truckFiyat = new System.Windows.Forms.Label();
            this.label_coopFiyat = new System.Windows.Forms.Label();
            this.label_fordFiyat = new System.Windows.Forms.Label();
            this.label_menuDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ford)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Truck)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Ford
            // 
            this.pictureBox_Ford.Enabled = false;
            this.pictureBox_Ford.Image = global::Traffic_Racer.Properties.Resources._1;
            this.pictureBox_Ford.Location = new System.Drawing.Point(335, 128);
            this.pictureBox_Ford.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Ford.Name = "pictureBox_Ford";
            this.pictureBox_Ford.Size = new System.Drawing.Size(99, 87);
            this.pictureBox_Ford.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Ford.TabIndex = 9;
            this.pictureBox_Ford.TabStop = false;
            // 
            // pictureBox_Coop
            // 
            this.pictureBox_Coop.Enabled = false;
            this.pictureBox_Coop.Image = global::Traffic_Racer.Properties.Resources._5;
            this.pictureBox_Coop.Location = new System.Drawing.Point(172, 128);
            this.pictureBox_Coop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Coop.Name = "pictureBox_Coop";
            this.pictureBox_Coop.Size = new System.Drawing.Size(99, 87);
            this.pictureBox_Coop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Coop.TabIndex = 8;
            this.pictureBox_Coop.TabStop = false;
            // 
            // pictureBox_Truck
            // 
            this.pictureBox_Truck.Enabled = false;
            this.pictureBox_Truck.Image = global::Traffic_Racer.Properties.Resources._2;
            this.pictureBox_Truck.Location = new System.Drawing.Point(12, 128);
            this.pictureBox_Truck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Truck.Name = "pictureBox_Truck";
            this.pictureBox_Truck.Size = new System.Drawing.Size(99, 87);
            this.pictureBox_Truck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Truck.TabIndex = 7;
            this.pictureBox_Truck.TabStop = false;
            // 
            // label_satinAlTruck
            // 
            this.label_satinAlTruck.AutoSize = true;
            this.label_satinAlTruck.BackColor = System.Drawing.Color.Black;
            this.label_satinAlTruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_satinAlTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_satinAlTruck.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_satinAlTruck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_satinAlTruck.Location = new System.Drawing.Point(16, 218);
            this.label_satinAlTruck.Name = "label_satinAlTruck";
            this.label_satinAlTruck.Size = new System.Drawing.Size(94, 29);
            this.label_satinAlTruck.TabIndex = 10;
            this.label_satinAlTruck.Text = "Satın Al";
            this.label_satinAlTruck.Click += new System.EventHandler(this.label_satinAlTruck_Click);
            this.label_satinAlTruck.MouseEnter += new System.EventHandler(this.label_satinAlTruck_MouseEnter);
            this.label_satinAlTruck.MouseLeave += new System.EventHandler(this.label_satinAlTruck_MouseLeave);
            // 
            // label_satinAlCoop
            // 
            this.label_satinAlCoop.AutoSize = true;
            this.label_satinAlCoop.BackColor = System.Drawing.Color.Black;
            this.label_satinAlCoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_satinAlCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_satinAlCoop.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_satinAlCoop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_satinAlCoop.Location = new System.Drawing.Point(176, 218);
            this.label_satinAlCoop.Name = "label_satinAlCoop";
            this.label_satinAlCoop.Size = new System.Drawing.Size(94, 29);
            this.label_satinAlCoop.TabIndex = 11;
            this.label_satinAlCoop.Text = "Satın Al";
            this.label_satinAlCoop.Click += new System.EventHandler(this.label_satinAlTruck_Click);
            this.label_satinAlCoop.MouseEnter += new System.EventHandler(this.label_satinAlTruck_MouseEnter);
            this.label_satinAlCoop.MouseLeave += new System.EventHandler(this.label_satinAlTruck_MouseLeave);
            // 
            // label_satinAlFord
            // 
            this.label_satinAlFord.AutoSize = true;
            this.label_satinAlFord.BackColor = System.Drawing.Color.Black;
            this.label_satinAlFord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_satinAlFord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_satinAlFord.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_satinAlFord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_satinAlFord.Location = new System.Drawing.Point(339, 218);
            this.label_satinAlFord.Name = "label_satinAlFord";
            this.label_satinAlFord.Size = new System.Drawing.Size(94, 29);
            this.label_satinAlFord.TabIndex = 12;
            this.label_satinAlFord.Text = "Satın Al";
            this.label_satinAlFord.Click += new System.EventHandler(this.label_satinAlTruck_Click);
            this.label_satinAlFord.MouseEnter += new System.EventHandler(this.label_satinAlTruck_MouseEnter);
            this.label_satinAlFord.MouseLeave += new System.EventHandler(this.label_satinAlTruck_MouseLeave);
            // 
            // label_Ford
            // 
            this.label_Ford.AutoSize = true;
            this.label_Ford.BackColor = System.Drawing.Color.Black;
            this.label_Ford.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Ford.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Ford.ForeColor = System.Drawing.Color.Maroon;
            this.label_Ford.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Ford.Location = new System.Drawing.Point(331, 159);
            this.label_Ford.Name = "label_Ford";
            this.label_Ford.Size = new System.Drawing.Size(106, 29);
            this.label_Ford.TabIndex = 15;
            this.label_Ford.Text = "Sahipsin";
            this.label_Ford.Visible = false;
            // 
            // label_Coop
            // 
            this.label_Coop.AutoSize = true;
            this.label_Coop.BackColor = System.Drawing.Color.Black;
            this.label_Coop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Coop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Coop.ForeColor = System.Drawing.Color.Maroon;
            this.label_Coop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Coop.Location = new System.Drawing.Point(167, 159);
            this.label_Coop.Name = "label_Coop";
            this.label_Coop.Size = new System.Drawing.Size(106, 29);
            this.label_Coop.TabIndex = 14;
            this.label_Coop.Text = "Sahipsin";
            this.label_Coop.Visible = false;
            // 
            // label_Truck
            // 
            this.label_Truck.AutoSize = true;
            this.label_Truck.BackColor = System.Drawing.Color.Black;
            this.label_Truck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Truck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Truck.ForeColor = System.Drawing.Color.Maroon;
            this.label_Truck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Truck.Location = new System.Drawing.Point(7, 159);
            this.label_Truck.Name = "label_Truck";
            this.label_Truck.Size = new System.Drawing.Size(106, 29);
            this.label_Truck.TabIndex = 13;
            this.label_Truck.Text = "Sahipsin";
            this.label_Truck.Visible = false;
            // 
            // satinAlinanKontrol
            // 
            this.satinAlinanKontrol.Tick += new System.EventHandler(this.satinAlinanKontrol_Tick);
            // 
            // label_para
            // 
            this.label_para.AutoSize = true;
            this.label_para.BackColor = System.Drawing.Color.Black;
            this.label_para.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_para.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_para.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_para.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_para.Location = new System.Drawing.Point(12, 9);
            this.label_para.Name = "label_para";
            this.label_para.Size = new System.Drawing.Size(156, 29);
            this.label_para.TabIndex = 16;
            this.label_para.Text = "Oyuncu Para:";
            // 
            // label_truckFiyat
            // 
            this.label_truckFiyat.AutoSize = true;
            this.label_truckFiyat.BackColor = System.Drawing.Color.Black;
            this.label_truckFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_truckFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_truckFiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_truckFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_truckFiyat.Location = new System.Drawing.Point(16, 100);
            this.label_truckFiyat.Name = "label_truckFiyat";
            this.label_truckFiyat.Size = new System.Drawing.Size(79, 25);
            this.label_truckFiyat.TabIndex = 17;
            this.label_truckFiyat.Text = "500 OP";
            // 
            // label_coopFiyat
            // 
            this.label_coopFiyat.AutoSize = true;
            this.label_coopFiyat.BackColor = System.Drawing.Color.Black;
            this.label_coopFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_coopFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_coopFiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_coopFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_coopFiyat.Location = new System.Drawing.Point(175, 100);
            this.label_coopFiyat.Name = "label_coopFiyat";
            this.label_coopFiyat.Size = new System.Drawing.Size(90, 25);
            this.label_coopFiyat.TabIndex = 18;
            this.label_coopFiyat.Text = "1000 OP";
            // 
            // label_fordFiyat
            // 
            this.label_fordFiyat.AutoSize = true;
            this.label_fordFiyat.BackColor = System.Drawing.Color.Black;
            this.label_fordFiyat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_fordFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_fordFiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_fordFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_fordFiyat.Location = new System.Drawing.Point(340, 100);
            this.label_fordFiyat.Name = "label_fordFiyat";
            this.label_fordFiyat.Size = new System.Drawing.Size(90, 25);
            this.label_fordFiyat.TabIndex = 19;
            this.label_fordFiyat.Text = "2500 OP";
            // 
            // label_menuDon
            // 
            this.label_menuDon.AutoSize = true;
            this.label_menuDon.BackColor = System.Drawing.Color.Black;
            this.label_menuDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_menuDon.ForeColor = System.Drawing.Color.White;
            this.label_menuDon.Location = new System.Drawing.Point(344, 303);
            this.label_menuDon.Name = "label_menuDon";
            this.label_menuDon.Size = new System.Drawing.Size(92, 18);
            this.label_menuDon.TabIndex = 20;
            this.label_menuDon.Text = "Menüye Dön";
            this.label_menuDon.Click += new System.EventHandler(this.label_menuDon_Click);
            this.label_menuDon.MouseEnter += new System.EventHandler(this.label_satinAlTruck_MouseEnter);
            this.label_menuDon.MouseLeave += new System.EventHandler(this.label_satinAlTruck_MouseLeave);
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label_menuDon);
            this.Controls.Add(this.label_fordFiyat);
            this.Controls.Add(this.label_coopFiyat);
            this.Controls.Add(this.label_truckFiyat);
            this.Controls.Add(this.label_para);
            this.Controls.Add(this.label_Ford);
            this.Controls.Add(this.label_Coop);
            this.Controls.Add(this.label_Truck);
            this.Controls.Add(this.label_satinAlFord);
            this.Controls.Add(this.label_satinAlCoop);
            this.Controls.Add(this.label_satinAlTruck);
            this.Controls.Add(this.pictureBox_Ford);
            this.Controls.Add(this.pictureBox_Coop);
            this.Controls.Add(this.pictureBox_Truck);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Market_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ford)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Truck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Ford;
        private System.Windows.Forms.PictureBox pictureBox_Coop;
        private System.Windows.Forms.PictureBox pictureBox_Truck;
        private System.Windows.Forms.Label label_satinAlTruck;
        private System.Windows.Forms.Label label_satinAlCoop;
        private System.Windows.Forms.Label label_satinAlFord;
        private System.Windows.Forms.Label label_Ford;
        private System.Windows.Forms.Label label_Coop;
        private System.Windows.Forms.Label label_Truck;
        private System.Windows.Forms.Timer satinAlinanKontrol;
        private System.Windows.Forms.Label label_para;
        private System.Windows.Forms.Label label_truckFiyat;
        private System.Windows.Forms.Label label_coopFiyat;
        private System.Windows.Forms.Label label_fordFiyat;
        private System.Windows.Forms.Label label_menuDon;
    }
}