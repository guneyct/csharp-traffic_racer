namespace Traffic_Racer
{
    partial class Yaris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yaris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_YanSınır = new System.Windows.Forms.Button();
            this.button_altSınır = new System.Windows.Forms.Button();
            this.button_ustSınır = new System.Windows.Forms.Button();
            this.button_yanSinir = new System.Windows.Forms.Button();
            this.label_Km = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yol = new System.Windows.Forms.PictureBox();
            this.label_kazPara = new System.Windows.Forms.Label();
            this.label_menuDon = new System.Windows.Forms.Label();
            this.carEraser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEraser)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_YanSınır
            // 
            this.button_YanSınır.BackColor = System.Drawing.Color.DarkGreen;
            this.button_YanSınır.Enabled = false;
            this.button_YanSınır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_YanSınır.Location = new System.Drawing.Point(369, -190);
            this.button_YanSınır.Margin = new System.Windows.Forms.Padding(4);
            this.button_YanSınır.Name = "button_YanSınır";
            this.button_YanSınır.Size = new System.Drawing.Size(54, 595);
            this.button_YanSınır.TabIndex = 2;
            this.button_YanSınır.UseVisualStyleBackColor = false;
            // 
            // button_altSınır
            // 
            this.button_altSınır.BackColor = System.Drawing.Color.Black;
            this.button_altSınır.Enabled = false;
            this.button_altSınır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_altSınır.Location = new System.Drawing.Point(-1, 393);
            this.button_altSınır.Margin = new System.Windows.Forms.Padding(4);
            this.button_altSınır.Name = "button_altSınır";
            this.button_altSınır.Size = new System.Drawing.Size(424, 70);
            this.button_altSınır.TabIndex = 3;
            this.button_altSınır.UseVisualStyleBackColor = false;
            // 
            // button_ustSınır
            // 
            this.button_ustSınır.Location = new System.Drawing.Point(1, -73);
            this.button_ustSınır.Margin = new System.Windows.Forms.Padding(4);
            this.button_ustSınır.Name = "button_ustSınır";
            this.button_ustSınır.Size = new System.Drawing.Size(489, 65);
            this.button_ustSınır.TabIndex = 4;
            this.button_ustSınır.Text = "button3";
            this.button_ustSınır.UseVisualStyleBackColor = true;
            // 
            // button_yanSinir
            // 
            this.button_yanSinir.BackColor = System.Drawing.Color.DarkGreen;
            this.button_yanSinir.Enabled = false;
            this.button_yanSinir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yanSinir.Location = new System.Drawing.Point(-1, -190);
            this.button_yanSinir.Margin = new System.Windows.Forms.Padding(4);
            this.button_yanSinir.Name = "button_yanSinir";
            this.button_yanSinir.Size = new System.Drawing.Size(22, 606);
            this.button_yanSinir.TabIndex = 5;
            this.button_yanSinir.UseVisualStyleBackColor = false;
            // 
            // label_Km
            // 
            this.label_Km.AutoSize = true;
            this.label_Km.BackColor = System.Drawing.Color.Black;
            this.label_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Km.ForeColor = System.Drawing.Color.White;
            this.label_Km.Location = new System.Drawing.Point(44, 398);
            this.label_Km.Name = "label_Km";
            this.label_Km.Size = new System.Drawing.Size(63, 25);
            this.label_Km.TabIndex = 8;
            this.label_Km.Text = "KM/H";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(116, 316);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_Yol
            // 
            this.pictureBox_Yol.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_Yol.Location = new System.Drawing.Point(12, -139);
            this.pictureBox_Yol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Yol.Name = "pictureBox_Yol";
            this.pictureBox_Yol.Size = new System.Drawing.Size(391, 533);
            this.pictureBox_Yol.TabIndex = 7;
            this.pictureBox_Yol.TabStop = false;
            // 
            // label_kazPara
            // 
            this.label_kazPara.AutoSize = true;
            this.label_kazPara.BackColor = System.Drawing.Color.Black;
            this.label_kazPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kazPara.ForeColor = System.Drawing.Color.White;
            this.label_kazPara.Location = new System.Drawing.Point(221, 398);
            this.label_kazPara.Name = "label_kazPara";
            this.label_kazPara.Size = new System.Drawing.Size(41, 25);
            this.label_kazPara.TabIndex = 9;
            this.label_kazPara.Text = "OP";
            // 
            // label_menuDon
            // 
            this.label_menuDon.AutoSize = true;
            this.label_menuDon.BackColor = System.Drawing.Color.Black;
            this.label_menuDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_menuDon.ForeColor = System.Drawing.Color.White;
            this.label_menuDon.Location = new System.Drawing.Point(296, 431);
            this.label_menuDon.Name = "label_menuDon";
            this.label_menuDon.Size = new System.Drawing.Size(92, 18);
            this.label_menuDon.TabIndex = 10;
            this.label_menuDon.Text = "Menüye Dön";
            this.label_menuDon.Click += new System.EventHandler(this.label_menuDon_Click);
            this.label_menuDon.MouseEnter += new System.EventHandler(this.label_menuDon_MouseEnter);
            this.label_menuDon.MouseLeave += new System.EventHandler(this.label_menuDon_MouseLeave);
            // 
            // carEraser
            // 
            this.carEraser.BackColor = System.Drawing.Color.Transparent;
            this.carEraser.Location = new System.Drawing.Point(-9, 456);
            this.carEraser.Margin = new System.Windows.Forms.Padding(4);
            this.carEraser.Name = "carEraser";
            this.carEraser.Size = new System.Drawing.Size(432, 69);
            this.carEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carEraser.TabIndex = 11;
            this.carEraser.TabStop = false;
            // 
            // Yaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 493);
            this.ControlBox = false;
            this.Controls.Add(this.carEraser);
            this.Controls.Add(this.label_menuDon);
            this.Controls.Add(this.label_kazPara);
            this.Controls.Add(this.label_Km);
            this.Controls.Add(this.button_altSınır);
            this.Controls.Add(this.button_yanSinir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_ustSınır);
            this.Controls.Add(this.button_YanSınır);
            this.Controls.Add(this.pictureBox_Yol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trafik Yarışçısı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Yaris_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carEraser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_YanSınır;
        private System.Windows.Forms.Button button_altSınır;
        private System.Windows.Forms.Button button_ustSınır;
        private System.Windows.Forms.Button button_yanSinir;
        private System.Windows.Forms.PictureBox pictureBox_Yol;
        private System.Windows.Forms.Label label_Km;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_kazPara;
        private System.Windows.Forms.Label label_menuDon;
        private System.Windows.Forms.PictureBox carEraser;
    }
}

