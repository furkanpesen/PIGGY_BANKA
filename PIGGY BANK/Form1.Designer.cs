namespace PIGGY_BANK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxKumbara = new System.Windows.Forms.PictureBox();
            this.panelDolum = new System.Windows.Forms.Panel();
            this.timerDolum = new System.Windows.Forms.Timer(this.components);
            this.buttonParaEkle = new System.Windows.Forms.Button();
            this.buttonKumbarayiKirma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKumbara)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelTitle.Location = new System.Drawing.Point(339, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PIGGY BANK";
            // 
            // pictureBoxKumbara
            // 
            this.pictureBoxKumbara.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKumbara.Image")));
            this.pictureBoxKumbara.Location = new System.Drawing.Point(288, 80);
            this.pictureBoxKumbara.Name = "pictureBoxKumbara";
            this.pictureBoxKumbara.Size = new System.Drawing.Size(285, 280);
            this.pictureBoxKumbara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKumbara.TabIndex = 2;
            this.pictureBoxKumbara.TabStop = false;
            this.pictureBoxKumbara.Click += new System.EventHandler(this.pictureBoxKumbara_Click);
            // 
            // panelDolum
            // 
            this.panelDolum.BackColor = System.Drawing.Color.Green;
            this.panelDolum.Location = new System.Drawing.Point(50, 350);
            this.panelDolum.Name = "panelDolum";
            this.panelDolum.Size = new System.Drawing.Size(200, 0);
            this.panelDolum.TabIndex = 3;
            // 
            // timerDolum
            // 
            this.timerDolum.Interval = 1000;
            // 
            // buttonParaEkle
            // 
            this.buttonParaEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParaEkle.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonParaEkle.Location = new System.Drawing.Point(50, 415);
            this.buttonParaEkle.Name = "buttonParaEkle";
            this.buttonParaEkle.Size = new System.Drawing.Size(150, 30);
            this.buttonParaEkle.TabIndex = 4;
            this.buttonParaEkle.Text = "Para Ekle";
            this.buttonParaEkle.UseVisualStyleBackColor = true;
            this.buttonParaEkle.Click += new System.EventHandler(this.buttonParaEkle_Click);
            // 
            // buttonKumbarayiKirma
            // 
            this.buttonKumbarayiKirma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKumbarayiKirma.ForeColor = System.Drawing.Color.Red;
            this.buttonKumbarayiKirma.Location = new System.Drawing.Point(335, 415);
            this.buttonKumbarayiKirma.Name = "buttonKumbarayiKirma";
            this.buttonKumbarayiKirma.Size = new System.Drawing.Size(150, 30);
            this.buttonKumbarayiKirma.TabIndex = 5;
            this.buttonKumbarayiKirma.Text = "Kumbarayı Kır!";
            this.buttonKumbarayiKirma.UseVisualStyleBackColor = true;
            this.buttonKumbarayiKirma.Click += new System.EventHandler(this.buttonKumbarayiKirma_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(595, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kumbarayı Yapıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10 Kuruş",
            "25 Kuruş",
            "50 Kuruş",
            "1 Lira",
            "5 Lira",
            "10 Lira",
            "25 Lira",
            "50 Lira"});
            this.comboBox1.Location = new System.Drawing.Point(36, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parayı seçiniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKumbarayiKirma);
            this.Controls.Add(this.buttonParaEkle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxKumbara);
            this.Controls.Add(this.panelDolum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKumbara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxKumbara;
        private System.Windows.Forms.Panel panelDolum;
        private System.Windows.Forms.Timer timerDolum;
        private System.Windows.Forms.Button buttonParaEkle;
        private System.Windows.Forms.Button buttonKumbarayiKirma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}