namespace T7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TulostusLB = new Label();
            AjomaaraCB = new ComboBox();
            LyhennysTB = new TextBox();
            NesteetTB = new TextBox();
            MuutkulutTB = new TextBox();
            PolttoaineTB = new TextBox();
            VakuutusTB = new TextBox();
            PesutTB = new TextBox();
            HuollotTB = new TextBox();
            RenkaatTB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Lainanlyhennys korkoineen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Verot / vuosi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(149, 15);
            label4.TabIndex = 2;
            label4.Text = "Vakuutusmaksut vuodessa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 87);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Polttoneste:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 87);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 9;
            label6.Text = "Ajetut kilometrit / vuosi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 61);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 8;
            label7.Text = "Renkaat vuodessa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 244);
            label8.Name = "label8";
            label8.Size = new Size(150, 15);
            label8.TabIndex = 7;
            label8.Text = "Syötä arvot kuukausitasolla";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 35);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 6;
            label9.Text = "Huollot vuodessa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(374, 9);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 5;
            label10.Text = "Pesut vuodessa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 358);
            label11.Name = "label11";
            label11.Size = new Size(196, 15);
            label11.TabIndex = 10;
            label11.Text = "Kustannukset kilometriä kohti ovat: ";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Location = new Point(214, 358);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(22, 15);
            TulostusLB.TabIndex = 11;
            TulostusLB.Text = "xxx";
            TulostusLB.Visible = false;
            // 
            // AjomaaraCB
            // 
            AjomaaraCB.FormattingEnabled = true;
            AjomaaraCB.Items.AddRange(new object[] { "Valitse oikea ajomäärä tästä", "2500", "5000", "10000", "15000", "20000", "25000", "30000", "35000", "40000", "45000", "50000", "55000", "60000" });
            AjomaaraCB.Location = new Point(515, 84);
            AjomaaraCB.Name = "AjomaaraCB";
            AjomaaraCB.Size = new Size(273, 23);
            AjomaaraCB.TabIndex = 12;
            AjomaaraCB.SelectedIndexChanged += AjomaaraCB_SelectedIndexChanged;
            // 
            // LyhennysTB
            // 
            LyhennysTB.Location = new Point(172, 6);
            LyhennysTB.Name = "LyhennysTB";
            LyhennysTB.Size = new Size(100, 23);
            LyhennysTB.TabIndex = 13;
            // 
            // NesteetTB
            // 
            NesteetTB.Location = new Point(172, 32);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(100, 23);
            NesteetTB.TabIndex = 14;
            // 
            // MuutkulutTB
            // 
            MuutkulutTB.Location = new Point(172, 58);
            MuutkulutTB.Name = "MuutkulutTB";
            MuutkulutTB.Size = new Size(100, 23);
            MuutkulutTB.TabIndex = 15;
            // 
            // PolttoaineTB
            // 
            PolttoaineTB.Location = new Point(172, 84);
            PolttoaineTB.Name = "PolttoaineTB";
            PolttoaineTB.Size = new Size(100, 23);
            PolttoaineTB.TabIndex = 16;
            // 
            // VakuutusTB
            // 
            VakuutusTB.Location = new Point(172, 110);
            VakuutusTB.Name = "VakuutusTB";
            VakuutusTB.Size = new Size(100, 23);
            VakuutusTB.TabIndex = 17;
            // 
            // PesutTB
            // 
            PesutTB.Location = new Point(515, 6);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(100, 23);
            PesutTB.TabIndex = 18;
            // 
            // HuollotTB
            // 
            HuollotTB.Location = new Point(515, 32);
            HuollotTB.Name = "HuollotTB";
            HuollotTB.Size = new Size(100, 23);
            HuollotTB.TabIndex = 19;
            // 
            // RenkaatTB
            // 
            RenkaatTB.Location = new Point(515, 58);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(100, 23);
            RenkaatTB.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RenkaatTB);
            Controls.Add(HuollotTB);
            Controls.Add(PesutTB);
            Controls.Add(VakuutusTB);
            Controls.Add(PolttoaineTB);
            Controls.Add(MuutkulutTB);
            Controls.Add(NesteetTB);
            Controls.Add(LyhennysTB);
            Controls.Add(AjomaaraCB);
            Controls.Add(TulostusLB);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kilometrikulutuslaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label TulostusLB;
        private ComboBox AjomaaraCB;
        private TextBox LyhennysTB;
        private TextBox NesteetTB;
        private TextBox MuutkulutTB;
        private TextBox PolttoaineTB;
        private TextBox VakuutusTB;
        private TextBox PesutTB;
        private TextBox HuollotTB;
        private TextBox RenkaatTB;
    }
}
