namespace Traffic_Racer
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label_GameStart = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label_Market = new System.Windows.Forms.Label();
            this.label_GenPara = new System.Windows.Forms.Label();
            this.label_Garage = new System.Windows.Forms.Label();
            this.label_About = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_GameStart
            // 
            resources.ApplyResources(this.label_GameStart, "label_GameStart");
            this.label_GameStart.BackColor = System.Drawing.Color.White;
            this.label_GameStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_GameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_GameStart.ForeColor = System.Drawing.Color.Black;
            this.label_GameStart.Name = "label_GameStart";
            this.label_GameStart.Click += new System.EventHandler(this.label_GameStart_Click);
            this.label_GameStart.MouseEnter += new System.EventHandler(this.label_GameStart_MouseEnter);
            this.label_GameStart.MouseLeave += new System.EventHandler(this.label_GameStart_MouseLeave);
            // 
            // label_Exit
            // 
            resources.ApplyResources(this.label_Exit, "label_Exit");
            this.label_Exit.BackColor = System.Drawing.Color.White;
            this.label_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Exit.ForeColor = System.Drawing.Color.Black;
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_GameStart_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_GameStart_MouseLeave);
            // 
            // label_Market
            // 
            resources.ApplyResources(this.label_Market, "label_Market");
            this.label_Market.BackColor = System.Drawing.Color.White;
            this.label_Market.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Market.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Market.ForeColor = System.Drawing.Color.Black;
            this.label_Market.Name = "label_Market";
            this.label_Market.Click += new System.EventHandler(this.label_Market_Click);
            this.label_Market.MouseEnter += new System.EventHandler(this.label_GameStart_MouseEnter);
            this.label_Market.MouseLeave += new System.EventHandler(this.label_GameStart_MouseLeave);
            // 
            // label_GenPara
            // 
            resources.ApplyResources(this.label_GenPara, "label_GenPara");
            this.label_GenPara.BackColor = System.Drawing.Color.White;
            this.label_GenPara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_GenPara.ForeColor = System.Drawing.Color.Black;
            this.label_GenPara.Name = "label_GenPara";
            // 
            // label_Garage
            // 
            resources.ApplyResources(this.label_Garage, "label_Garage");
            this.label_Garage.BackColor = System.Drawing.Color.White;
            this.label_Garage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Garage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Garage.ForeColor = System.Drawing.Color.Black;
            this.label_Garage.Name = "label_Garage";
            this.label_Garage.Click += new System.EventHandler(this.label_Garage_Click);
            this.label_Garage.MouseEnter += new System.EventHandler(this.label_GameStart_MouseEnter);
            this.label_Garage.MouseLeave += new System.EventHandler(this.label_GameStart_MouseLeave);
            // 
            // label_About
            // 
            resources.ApplyResources(this.label_About, "label_About");
            this.label_About.BackColor = System.Drawing.Color.White;
            this.label_About.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_About.ForeColor = System.Drawing.Color.Black;
            this.label_About.Name = "label_About";
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            this.label_About.MouseEnter += new System.EventHandler(this.label_GameStart_MouseEnter);
            this.label_About.MouseLeave += new System.EventHandler(this.label_GameStart_MouseLeave);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.label_Garage);
            this.Controls.Add(this.label_GenPara);
            this.Controls.Add(this.label_Market);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.label_GameStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GameStart;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Market;
        public System.Windows.Forms.Label label_GenPara;
        private System.Windows.Forms.Label label_Garage;
        private System.Windows.Forms.Label label_About;
    }
}