namespace Autokululaskuri
{
    partial class Autokulutuslaskuri
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
            this.km = new System.Windows.Forms.Label();
            this.hinta = new System.Windows.Forms.Label();
            this.prosentti = new System.Windows.Forms.Label();
            this.vakuutus = new System.Windows.Forms.Label();
            this.huollot = new System.Windows.Forms.Label();
            this.renkaat = new System.Windows.Forms.Label();
            this.pesut = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kilometritvuodessa = new System.Windows.Forms.ComboBox();
            this.muut = new System.Windows.Forms.Label();
            this.polttoaineet = new System.Windows.Forms.Label();
            this.pysakointi = new System.Windows.Forms.Label();
            this.nesteet = new System.Windows.Forms.Label();
            this.lyhennys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tulosperkm = new System.Windows.Forms.Label();
            this.hankintahinta = new System.Windows.Forms.TextBox();
            this.arvonalenema = new System.Windows.Forms.TextBox();
            this.vakuutusmaksu = new System.Windows.Forms.TextBox();
            this.vuosihuollot = new System.Windows.Forms.TextBox();
            this.renkaatvuodessa = new System.Windows.Forms.TextBox();
            this.pesutvuodessa = new System.Windows.Forms.TextBox();
            this.lyhennyskorkoineen = new System.Windows.Forms.TextBox();
            this.lisattavatnesteet = new System.Windows.Forms.TextBox();
            this.pysakointikuukaudessa = new System.Windows.Forms.TextBox();
            this.polttoaineetkuukaudessa = new System.Windows.Forms.TextBox();
            this.muutkulutkuukaudessa = new System.Windows.Forms.TextBox();
            this.laskee = new System.Windows.Forms.Button();
            this.kustkk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kmkk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Location = new System.Drawing.Point(12, 209);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(173, 13);
            this.km.TabIndex = 0;
            this.km.Text = "Autolla ajettavat kilometrit per vuosi";
            // 
            // hinta
            // 
            this.hinta.AutoSize = true;
            this.hinta.Location = new System.Drawing.Point(12, 13);
            this.hinta.Name = "hinta";
            this.hinta.Size = new System.Drawing.Size(73, 13);
            this.hinta.TabIndex = 1;
            this.hinta.Text = "Hankintahinta";
            // 
            // prosentti
            // 
            this.prosentti.AutoSize = true;
            this.prosentti.Location = new System.Drawing.Point(12, 39);
            this.prosentti.Name = "prosentti";
            this.prosentti.Size = new System.Drawing.Size(121, 13);
            this.prosentti.TabIndex = 2;
            this.prosentti.Text = "Arvon alenema prosentti";
            // 
            // vakuutus
            // 
            this.vakuutus.AutoSize = true;
            this.vakuutus.Location = new System.Drawing.Point(12, 65);
            this.vakuutus.Name = "vakuutus";
            this.vakuutus.Size = new System.Drawing.Size(132, 13);
            this.vakuutus.TabIndex = 5;
            this.vakuutus.Text = "Vakuutusmaksu vuodessa";
            // 
            // huollot
            // 
            this.huollot.AutoSize = true;
            this.huollot.Location = new System.Drawing.Point(12, 91);
            this.huollot.Name = "huollot";
            this.huollot.Size = new System.Drawing.Size(89, 13);
            this.huollot.TabIndex = 8;
            this.huollot.Text = "Huollot vuodessa";
            // 
            // renkaat
            // 
            this.renkaat.AutoSize = true;
            this.renkaat.Location = new System.Drawing.Point(12, 117);
            this.renkaat.Name = "renkaat";
            this.renkaat.Size = new System.Drawing.Size(97, 13);
            this.renkaat.TabIndex = 9;
            this.renkaat.Text = "Renkaat vuodessa";
            // 
            // pesut
            // 
            this.pesut.AutoSize = true;
            this.pesut.Location = new System.Drawing.Point(12, 143);
            this.pesut.Name = "pesut";
            this.pesut.Size = new System.Drawing.Size(83, 13);
            this.pesut.TabIndex = 10;
            this.pesut.Text = "Pesut vuodessa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Kuukausittaiset menot";
            // 
            // kilometritvuodessa
            // 
            this.kilometritvuodessa.FormattingEnabled = true;
            this.kilometritvuodessa.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "95000",
            "100000"});
            this.kilometritvuodessa.Location = new System.Drawing.Point(191, 206);
            this.kilometritvuodessa.Name = "kilometritvuodessa";
            this.kilometritvuodessa.Size = new System.Drawing.Size(121, 21);
            this.kilometritvuodessa.TabIndex = 12;
            // 
            // muut
            // 
            this.muut.AutoSize = true;
            this.muut.Location = new System.Drawing.Point(318, 143);
            this.muut.Name = "muut";
            this.muut.Size = new System.Drawing.Size(57, 13);
            this.muut.TabIndex = 17;
            this.muut.Text = "Muut kulut";
            // 
            // polttoaineet
            // 
            this.polttoaineet.AutoSize = true;
            this.polttoaineet.Location = new System.Drawing.Point(318, 117);
            this.polttoaineet.Name = "polttoaineet";
            this.polttoaineet.Size = new System.Drawing.Size(63, 13);
            this.polttoaineet.TabIndex = 16;
            this.polttoaineet.Text = "Polttoaineet";
            // 
            // pysakointi
            // 
            this.pysakointi.AutoSize = true;
            this.pysakointi.Location = new System.Drawing.Point(318, 91);
            this.pysakointi.Name = "pysakointi";
            this.pysakointi.Size = new System.Drawing.Size(55, 13);
            this.pysakointi.TabIndex = 15;
            this.pysakointi.Text = "Pysäköinti";
            // 
            // nesteet
            // 
            this.nesteet.AutoSize = true;
            this.nesteet.Location = new System.Drawing.Point(318, 65);
            this.nesteet.Name = "nesteet";
            this.nesteet.Size = new System.Drawing.Size(115, 13);
            this.nesteet.TabIndex = 14;
            this.nesteet.Text = "Lisättävät nesteet yms.";
            // 
            // lyhennys
            // 
            this.lyhennys.AutoSize = true;
            this.lyhennys.Location = new System.Drawing.Point(318, 39);
            this.lyhennys.Name = "lyhennys";
            this.lyhennys.Size = new System.Drawing.Size(136, 13);
            this.lyhennys.TabIndex = 13;
            this.lyhennys.Text = "Lainanlyhennys korkoineen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kustannukset kilometriä kohden ovat:";
            // 
            // tulosperkm
            // 
            this.tulosperkm.AutoSize = true;
            this.tulosperkm.Location = new System.Drawing.Point(204, 247);
            this.tulosperkm.Name = "tulosperkm";
            this.tulosperkm.Size = new System.Drawing.Size(22, 13);
            this.tulosperkm.TabIndex = 19;
            this.tulosperkm.Text = "xxx";
            this.tulosperkm.Visible = false;
            this.tulosperkm.Click += new System.EventHandler(this.tulosperkm_Click);
            // 
            // hankintahinta
            // 
            this.hankintahinta.Location = new System.Drawing.Point(191, 10);
            this.hankintahinta.Name = "hankintahinta";
            this.hankintahinta.Size = new System.Drawing.Size(100, 20);
            this.hankintahinta.TabIndex = 20;
            // 
            // arvonalenema
            // 
            this.arvonalenema.Location = new System.Drawing.Point(191, 36);
            this.arvonalenema.Name = "arvonalenema";
            this.arvonalenema.Size = new System.Drawing.Size(100, 20);
            this.arvonalenema.TabIndex = 21;
            // 
            // vakuutusmaksu
            // 
            this.vakuutusmaksu.Location = new System.Drawing.Point(191, 62);
            this.vakuutusmaksu.Name = "vakuutusmaksu";
            this.vakuutusmaksu.Size = new System.Drawing.Size(100, 20);
            this.vakuutusmaksu.TabIndex = 22;
            // 
            // vuosihuollot
            // 
            this.vuosihuollot.Location = new System.Drawing.Point(191, 88);
            this.vuosihuollot.Name = "vuosihuollot";
            this.vuosihuollot.Size = new System.Drawing.Size(100, 20);
            this.vuosihuollot.TabIndex = 23;
            // 
            // renkaatvuodessa
            // 
            this.renkaatvuodessa.Location = new System.Drawing.Point(191, 114);
            this.renkaatvuodessa.Name = "renkaatvuodessa";
            this.renkaatvuodessa.Size = new System.Drawing.Size(100, 20);
            this.renkaatvuodessa.TabIndex = 24;
            // 
            // pesutvuodessa
            // 
            this.pesutvuodessa.Location = new System.Drawing.Point(191, 140);
            this.pesutvuodessa.Name = "pesutvuodessa";
            this.pesutvuodessa.Size = new System.Drawing.Size(100, 20);
            this.pesutvuodessa.TabIndex = 25;
            // 
            // lyhennyskorkoineen
            // 
            this.lyhennyskorkoineen.Location = new System.Drawing.Point(456, 36);
            this.lyhennyskorkoineen.Name = "lyhennyskorkoineen";
            this.lyhennyskorkoineen.Size = new System.Drawing.Size(100, 20);
            this.lyhennyskorkoineen.TabIndex = 27;
            // 
            // lisattavatnesteet
            // 
            this.lisattavatnesteet.Location = new System.Drawing.Point(456, 62);
            this.lisattavatnesteet.Name = "lisattavatnesteet";
            this.lisattavatnesteet.Size = new System.Drawing.Size(100, 20);
            this.lisattavatnesteet.TabIndex = 28;
            // 
            // pysakointikuukaudessa
            // 
            this.pysakointikuukaudessa.Location = new System.Drawing.Point(456, 88);
            this.pysakointikuukaudessa.Name = "pysakointikuukaudessa";
            this.pysakointikuukaudessa.Size = new System.Drawing.Size(100, 20);
            this.pysakointikuukaudessa.TabIndex = 29;
            // 
            // polttoaineetkuukaudessa
            // 
            this.polttoaineetkuukaudessa.Location = new System.Drawing.Point(456, 114);
            this.polttoaineetkuukaudessa.Name = "polttoaineetkuukaudessa";
            this.polttoaineetkuukaudessa.Size = new System.Drawing.Size(100, 20);
            this.polttoaineetkuukaudessa.TabIndex = 30;
            // 
            // muutkulutkuukaudessa
            // 
            this.muutkulutkuukaudessa.Location = new System.Drawing.Point(456, 140);
            this.muutkulutkuukaudessa.Name = "muutkulutkuukaudessa";
            this.muutkulutkuukaudessa.Size = new System.Drawing.Size(100, 20);
            this.muutkulutkuukaudessa.TabIndex = 31;
            // 
            // laskee
            // 
            this.laskee.Location = new System.Drawing.Point(456, 203);
            this.laskee.Name = "laskee";
            this.laskee.Size = new System.Drawing.Size(75, 23);
            this.laskee.TabIndex = 32;
            this.laskee.Text = "Laske";
            this.laskee.UseVisualStyleBackColor = true;
            this.laskee.Click += new System.EventHandler(this.laskee_Click);
            // 
            // kustkk
            // 
            this.kustkk.AutoSize = true;
            this.kustkk.Location = new System.Drawing.Point(204, 315);
            this.kustkk.Name = "kustkk";
            this.kustkk.Size = new System.Drawing.Size(22, 13);
            this.kustkk.TabIndex = 34;
            this.kustkk.Text = "xxx";
            this.kustkk.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kustannukset kuukaudessa:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(456, 278);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "Laske";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kilometrit kuukaudessa";
            // 
            // kmkk
            // 
            this.kmkk.Location = new System.Drawing.Point(191, 280);
            this.kmkk.Name = "kmkk";
            this.kmkk.Size = new System.Drawing.Size(100, 20);
            this.kmkk.TabIndex = 37;
            // 
            // Autokulutuslaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 402);
            this.Controls.Add(this.kmkk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.kustkk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laskee);
            this.Controls.Add(this.muutkulutkuukaudessa);
            this.Controls.Add(this.polttoaineetkuukaudessa);
            this.Controls.Add(this.pysakointikuukaudessa);
            this.Controls.Add(this.lisattavatnesteet);
            this.Controls.Add(this.lyhennyskorkoineen);
            this.Controls.Add(this.pesutvuodessa);
            this.Controls.Add(this.renkaatvuodessa);
            this.Controls.Add(this.vuosihuollot);
            this.Controls.Add(this.vakuutusmaksu);
            this.Controls.Add(this.arvonalenema);
            this.Controls.Add(this.hankintahinta);
            this.Controls.Add(this.tulosperkm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muut);
            this.Controls.Add(this.polttoaineet);
            this.Controls.Add(this.pysakointi);
            this.Controls.Add(this.nesteet);
            this.Controls.Add(this.lyhennys);
            this.Controls.Add(this.kilometritvuodessa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pesut);
            this.Controls.Add(this.renkaat);
            this.Controls.Add(this.huollot);
            this.Controls.Add(this.vakuutus);
            this.Controls.Add(this.prosentti);
            this.Controls.Add(this.hinta);
            this.Controls.Add(this.km);
            this.Name = "Autokulutuslaskuri";
            this.Text = "Autokulutuslaskuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Label hinta;
        private System.Windows.Forms.Label prosentti;
        private System.Windows.Forms.Label vakuutus;
        private System.Windows.Forms.Label huollot;
        private System.Windows.Forms.Label renkaat;
        private System.Windows.Forms.Label pesut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox kilometritvuodessa;
        private System.Windows.Forms.Label muut;
        private System.Windows.Forms.Label polttoaineet;
        private System.Windows.Forms.Label pysakointi;
        private System.Windows.Forms.Label nesteet;
        private System.Windows.Forms.Label lyhennys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulosperkm;
        private System.Windows.Forms.TextBox hankintahinta;
        private System.Windows.Forms.TextBox arvonalenema;
        private System.Windows.Forms.TextBox vakuutusmaksu;
        private System.Windows.Forms.TextBox vuosihuollot;
        private System.Windows.Forms.TextBox renkaatvuodessa;
        private System.Windows.Forms.TextBox pesutvuodessa;
        private System.Windows.Forms.TextBox lyhennyskorkoineen;
        private System.Windows.Forms.TextBox lisattavatnesteet;
        private System.Windows.Forms.TextBox pysakointikuukaudessa;
        private System.Windows.Forms.TextBox polttoaineetkuukaudessa;
        private System.Windows.Forms.TextBox muutkulutkuukaudessa;
        private System.Windows.Forms.Button laskee;
        private System.Windows.Forms.Label kustkk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kmkk;
    }
}

