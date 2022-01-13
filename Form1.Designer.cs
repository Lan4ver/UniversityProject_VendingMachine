namespace Projekt1_Podorozhnyi50402
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWaluta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.btnCurrP = new System.Windows.Forms.Button();
            this.btnCurrJ = new System.Windows.Forms.Button();
            this.btnCurrD = new System.Windows.Forms.Button();
            this.btnCurrPe = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRB = new System.Windows.Forms.Button();
            this.btnLB = new System.Windows.Forms.Button();
            this.btnRT = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.btnKardPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maszyna Vendingowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Maksym Podorozhnyi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karta Studencka(numer): 50402";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produkty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(510, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wybierz walute";
            // 
            // cmbWaluta
            // 
            this.cmbWaluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbWaluta.FormattingEnabled = true;
            this.cmbWaluta.Items.AddRange(new object[] {
            "Złt",
            "Szekel",
            "Grivnia"});
            this.cmbWaluta.Location = new System.Drawing.Point(518, 33);
            this.cmbWaluta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWaluta.Name = "cmbWaluta";
            this.cmbWaluta.Size = new System.Drawing.Size(137, 33);
            this.cmbWaluta.TabIndex = 5;
            this.cmbWaluta.Text = "Złt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(513, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rodzaj płatności";
            // 
            // cmbSP
            // 
            this.cmbSP.Enabled = false;
            this.cmbSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSP.FormattingEnabled = true;
            this.cmbSP.Items.AddRange(new object[] {
            "Kartą",
            "Gotówką"});
            this.cmbSP.Location = new System.Drawing.Point(514, 106);
            this.cmbSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSP.Name = "cmbSP";
            this.cmbSP.Size = new System.Drawing.Size(144, 33);
            this.cmbSP.TabIndex = 7;
            this.cmbSP.Text = "Kartą";
            this.cmbSP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(513, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wrzucona ilość";
            // 
            // txtPayed
            // 
            this.txtPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPayed.Location = new System.Drawing.Point(514, 378);
            this.txtPayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.ReadOnly = true;
            this.txtPayed.Size = new System.Drawing.Size(167, 30);
            this.txtPayed.TabIndex = 9;
            this.txtPayed.Text = "0.0";
            // 
            // btnCurrP
            // 
            this.btnCurrP.Enabled = false;
            this.btnCurrP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrP.Location = new System.Drawing.Point(517, 184);
            this.btnCurrP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrP.Name = "btnCurrP";
            this.btnCurrP.Size = new System.Drawing.Size(81, 75);
            this.btnCurrP.TabIndex = 13;
            this.btnCurrP.Text = "0.5";
            this.btnCurrP.UseVisualStyleBackColor = true;
            this.btnCurrP.Click += new System.EventHandler(this.currencyButtonClicked);
            // 
            // btnCurrJ
            // 
            this.btnCurrJ.Enabled = false;
            this.btnCurrJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrJ.Location = new System.Drawing.Point(604, 184);
            this.btnCurrJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrJ.Name = "btnCurrJ";
            this.btnCurrJ.Size = new System.Drawing.Size(81, 75);
            this.btnCurrJ.TabIndex = 13;
            this.btnCurrJ.Text = "1";
            this.btnCurrJ.UseVisualStyleBackColor = true;
            this.btnCurrJ.Click += new System.EventHandler(this.currencyButtonClicked);
            // 
            // btnCurrD
            // 
            this.btnCurrD.Enabled = false;
            this.btnCurrD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrD.Location = new System.Drawing.Point(518, 266);
            this.btnCurrD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrD.Name = "btnCurrD";
            this.btnCurrD.Size = new System.Drawing.Size(81, 75);
            this.btnCurrD.TabIndex = 13;
            this.btnCurrD.Text = "2";
            this.btnCurrD.UseVisualStyleBackColor = true;
            this.btnCurrD.Click += new System.EventHandler(this.currencyButtonClicked);
            // 
            // btnCurrPe
            // 
            this.btnCurrPe.Enabled = false;
            this.btnCurrPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrPe.Location = new System.Drawing.Point(604, 266);
            this.btnCurrPe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrPe.Name = "btnCurrPe";
            this.btnCurrPe.Size = new System.Drawing.Size(81, 75);
            this.btnCurrPe.TabIndex = 13;
            this.btnCurrPe.Text = "5";
            this.btnCurrPe.UseVisualStyleBackColor = true;
            this.btnCurrPe.Click += new System.EventHandler(this.currencyButtonClicked);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.Location = new System.Drawing.Point(514, 419);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(171, 81);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "Zapłac";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.PayCashBtnClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(532, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 39);
            this.label8.TabIndex = 15;
            this.label8.Text = "Włozyć";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(301, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Do zapłaty";
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtToPay.Location = new System.Drawing.Point(305, 470);
            this.txtToPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.ReadOnly = true;
            this.txtToPay.Size = new System.Drawing.Size(100, 30);
            this.txtToPay.TabIndex = 17;
            this.txtToPay.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zbliż kartę";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(269, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(405, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "3,5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(267, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(413, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "1";
            // 
            // btnRB
            // 
            this.btnRB.BackgroundImage = global::Projekt1_Podorozhnyi50402.Properties.Resources._4657_970;
            this.btnRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRB.Location = new System.Drawing.Point(373, 292);
            this.btnRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRB.Name = "btnRB";
            this.btnRB.Size = new System.Drawing.Size(109, 110);
            this.btnRB.TabIndex = 23;
            this.btnRB.UseVisualStyleBackColor = true;
            this.btnRB.Click += new System.EventHandler(this.productButtonClicked);
            // 
            // btnLB
            // 
            this.btnLB.BackgroundImage = global::Projekt1_Podorozhnyi50402.Properties.Resources.smol_muszynianka;
            this.btnLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLB.Location = new System.Drawing.Point(229, 292);
            this.btnLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLB.Name = "btnLB";
            this.btnLB.Size = new System.Drawing.Size(109, 110);
            this.btnLB.TabIndex = 22;
            this.btnLB.UseVisualStyleBackColor = true;
            this.btnLB.Click += new System.EventHandler(this.productButtonClicked);
            // 
            // btnRT
            // 
            this.btnRT.BackgroundImage = global::Projekt1_Podorozhnyi50402.Properties.Resources.vedro__ocinkovannoe__10l_avesta_525x600_1000x1000;
            this.btnRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRT.Location = new System.Drawing.Point(373, 144);
            this.btnRT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRT.Name = "btnRT";
            this.btnRT.Size = new System.Drawing.Size(109, 110);
            this.btnRT.TabIndex = 21;
            this.btnRT.UseVisualStyleBackColor = true;
            this.btnRT.Click += new System.EventHandler(this.productButtonClicked);
            // 
            // btnLT
            // 
            this.btnLT.BackgroundImage = global::Projekt1_Podorozhnyi50402.Properties.Resources.lopata_shtykovaya_000000278_html_76070172612498;
            this.btnLT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLT.Location = new System.Drawing.Point(229, 144);
            this.btnLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(109, 110);
            this.btnLT.TabIndex = 20;
            this.btnLT.UseVisualStyleBackColor = true;
            this.btnLT.Click += new System.EventHandler(this.productButtonClicked);
            // 
            // btnKardPay
            // 
            this.btnKardPay.BackgroundImage = global::Projekt1_Podorozhnyi50402.Properties.Resources.Karta;
            this.btnKardPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKardPay.Enabled = false;
            this.btnKardPay.Location = new System.Drawing.Point(15, 252);
            this.btnKardPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKardPay.Name = "btnKardPay";
            this.btnKardPay.Size = new System.Drawing.Size(157, 150);
            this.btnKardPay.TabIndex = 19;
            this.btnKardPay.UseVisualStyleBackColor = true;
            this.btnKardPay.Click += new System.EventHandler(this.PayByCardButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRB);
            this.Controls.Add(this.btnLB);
            this.Controls.Add(this.btnRT);
            this.Controls.Add(this.btnLT);
            this.Controls.Add(this.btnKardPay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtToPay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCurrPe);
            this.Controls.Add(this.btnCurrD);
            this.Controls.Add(this.btnCurrJ);
            this.Controls.Add(this.btnCurrP);
            this.Controls.Add(this.txtPayed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbWaluta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWaluta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.Button btnCurrP;
        private System.Windows.Forms.Button btnCurrJ;
        private System.Windows.Forms.Button btnCurrD;
        private System.Windows.Forms.Button btnCurrPe;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKardPay;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.Button btnRT;
        private System.Windows.Forms.Button btnLB;
        private System.Windows.Forms.Button btnRB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

