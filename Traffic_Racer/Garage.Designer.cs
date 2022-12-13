namespace Traffic_Racer
{
    partial class Garage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garage));
            this.pictureBox_Ford = new System.Windows.Forms.PictureBox();
            this.pictureBox_Coop = new System.Windows.Forms.PictureBox();
            this.pictureBox_Truck = new System.Windows.Forms.PictureBox();
            this.pictureBox_Stock = new System.Windows.Forms.PictureBox();
            this.aracKontrol = new System.Windows.Forms.Timer(this.components);
            this.label_kilitTruck = new System.Windows.Forms.Label();
            this.label_kilitCoop = new System.Windows.Forms.Label();
            this.label_kilitFord = new System.Windows.Forms.Label();
            this.label_menuDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ford)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Ford
            // 
            this.pictureBox_Ford.Enabled = false;
            this.pictureBox_Ford.Image = global::Traffic_Racer.Properties.Resources._1;
            this.pictureBox_Ford.Location = new System.Drawing.Point(326, 12);
            this.pictureBox_Ford.Name = "pictureBox_Ford";
            this.pictureBox_Ford.Size = new System.Drawing.Size(98, 87);
            this.pictureBox_Ford.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Ford.TabIndex = 6;
            this.pictureBox_Ford.TabStop = false;
            this.pictureBox_Ford.Click += new System.EventHandler(this.pictureBox_Stock_Click);
            this.pictureBox_Ford.MouseEnter += new System.EventHandler(this.pictureBox_Stock_MouseEnter);
            this.pictureBox_Ford.MouseLeave += new System.EventHandler(this.pictureBox_Stock_MouseLeave);
            // 
            // pictureBox_Coop
            // 
            this.pictureBox_Coop.Enabled = false;
            this.pictureBox_Coop.Image = global::Traffic_Racer.Properties.Resources._5;
            this.pictureBox_Coop.Location = new System.Drawing.Point(221, 12);
            this.pictureBox_Coop.Name = "pictureBox_Coop";
            this.pictureBox_Coop.Size = new System.Drawing.Size(98, 87);
            this.pictureBox_Coop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Coop.TabIndex = 4;
            this.pictureBox_Coop.TabStop = false;
            this.pictureBox_Coop.Click += new System.EventHandler(this.pictureBox_Stock_Click);
            this.pictureBox_Coop.MouseEnter += new System.EventHandler(this.pictureBox_Stock_MouseEnter);
            this.pictureBox_Coop.MouseLeave += new System.EventHandler(this.pictureBox_Stock_MouseLeave);
            // 
            // pictureBox_Truck
            // 
            this.pictureBox_Truck.Enabled = false;
            this.pictureBox_Truck.Image = global::Traffic_Racer.Properties.Resources._2;
            this.pictureBox_Truck.Location = new System.Drawing.Point(116, 12);
            this.pictureBox_Truck.Name = "pictureBox_Truck";
            this.pictureBox_Truck.Size = new System.Drawing.Size(98, 87);
            this.pictureBox_Truck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Truck.TabIndex = 2;
            this.pictureBox_Truck.TabStop = false;
            this.pictureBox_Truck.Click += new System.EventHandler(this.pictureBox_Stock_Click);
            this.pictureBox_Truck.MouseEnter += new System.EventHandler(this.pictureBox_Stock_MouseEnter);
            this.pictureBox_Truck.MouseLeave += new System.EventHandler(this.pictureBox_Stock_MouseLeave);
            // 
            // pictureBox_Stock
            // 
            this.pictureBox_Stock.Image = global::Traffic_Racer.Properties.Resources.Stock;
            this.pictureBox_Stock.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Stock.Name = "pictureBox_Stock";
            this.pictureBox_Stock.Size = new System.Drawing.Size(98, 87);
            this.pictureBox_Stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Stock.TabIndex = 0;
            this.pictureBox_Stock.TabStop = false;
            this.pictureBox_Stock.Click += new System.EventHandler(this.pictureBox_Stock_Click);
            this.pictureBox_Stock.MouseEnter += new System.EventHandler(this.pictureBox_Stock_MouseEnter);
            this.pictureBox_Stock.MouseLeave += new System.EventHandler(this.pictureBox_Stock_MouseLeave);
            // 
            // aracKontrol
            // 
            this.aracKontrol.Tick += new System.EventHandler(this.aracKontrol_Tick);
            // 
            // label_kilitTruck
            // 
            this.label_kilitTruck.AutoSize = true;
            this.label_kilitTruck.BackColor = System.Drawing.Color.Black;
            this.label_kilitTruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_kilitTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_kilitTruck.ForeColor = System.Drawing.Color.Maroon;
            this.label_kilitTruck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_kilitTruck.Location = new System.Drawing.Point(120, 43);
            this.label_kilitTruck.Name = "label_kilitTruck";
            this.label_kilitTruck.Size = new System.Drawing.Size(89, 29);
            this.label_kilitTruck.TabIndex = 7;
            this.label_kilitTruck.Text = "KİLİTLİ";
            // 
            // label_kilitCoop
            // 
            this.label_kilitCoop.AutoSize = true;
            this.label_kilitCoop.BackColor = System.Drawing.Color.Black;
            this.label_kilitCoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_kilitCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_kilitCoop.ForeColor = System.Drawing.Color.Maroon;
            this.label_kilitCoop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_kilitCoop.Location = new System.Drawing.Point(229, 43);
            this.label_kilitCoop.Name = "label_kilitCoop";
            this.label_kilitCoop.Size = new System.Drawing.Size(89, 29);
            this.label_kilitCoop.TabIndex = 8;
            this.label_kilitCoop.Text = "KİLİTLİ";
            // 
            // label_kilitFord
            // 
            this.label_kilitFord.AutoSize = true;
            this.label_kilitFord.BackColor = System.Drawing.Color.Black;
            this.label_kilitFord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_kilitFord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_kilitFord.ForeColor = System.Drawing.Color.Maroon;
            this.label_kilitFord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_kilitFord.Location = new System.Drawing.Point(332, 43);
            this.label_kilitFord.Name = "label_kilitFord";
            this.label_kilitFord.Size = new System.Drawing.Size(89, 29);
            this.label_kilitFord.TabIndex = 9;
            this.label_kilitFord.Text = "KİLİTLİ";
            // 
            // label_menuDon
            // 
            this.label_menuDon.AutoSize = true;
            this.label_menuDon.BackColor = System.Drawing.Color.Black;
            this.label_menuDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_menuDon.ForeColor = System.Drawing.Color.White;
            this.label_menuDon.Location = new System.Drawing.Point(323, 141);
            this.label_menuDon.Name = "label_menuDon";
            this.label_menuDon.Size = new System.Drawing.Size(92, 18);
            this.label_menuDon.TabIndex = 11;
            this.label_menuDon.Text = "Menüye Dön";
            this.label_menuDon.Click += new System.EventHandler(this.label_menuDon_Click);
            this.label_menuDon.MouseEnter += new System.EventHandler(this.label_menuDon_MouseEnter);
            this.label_menuDon.MouseLeave += new System.EventHandler(this.label_menuDon_MouseLeave);
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(439, 183);
            this.ControlBox = false;
            this.Controls.Add(this.label_menuDon);
            this.Controls.Add(this.label_kilitFord);
            this.Controls.Add(this.label_kilitCoop);
            this.Controls.Add(this.label_kilitTruck);
            this.Controls.Add(this.pictureBox_Ford);
            this.Controls.Add(this.pictureBox_Coop);
            this.Controls.Add(this.pictureBox_Truck);
            this.Controls.Add(this.pictureBox_Stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Garage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trafik Yarışçısı";
            this.Load += new System.EventHandler(this.Garage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ford)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Stock;
        private System.Windows.Forms.PictureBox pictureBox_Truck;
        private System.Windows.Forms.PictureBox pictureBox_Coop;
        private System.Windows.Forms.PictureBox pictureBox_Ford;
        private System.Windows.Forms.Timer aracKontrol;
        private System.Windows.Forms.Label label_kilitTruck;
        private System.Windows.Forms.Label label_kilitCoop;
        private System.Windows.Forms.Label label_kilitFord;
        private System.Windows.Forms.Label label_menuDon;
    }
}