namespace Hotellijarjestelma
{
    partial class Kirjautumisikkuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirjautumisikkuna));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kirjautumispaneeli = new System.Windows.Forms.Panel();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.textBoxKayttaja = new System.Windows.Forms.TextBox();
            this.textBoxSalasana = new System.Windows.Forms.TextBox();
            this.buttonKirjaudu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Kirjautumispaneeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kirjaudu sisään";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kirjautumispaneeli
            // 
            this.Kirjautumispaneeli.Controls.Add(this.buttonKirjaudu);
            this.Kirjautumispaneeli.Controls.Add(this.textBoxSalasana);
            this.Kirjautumispaneeli.Controls.Add(this.textBoxKayttaja);
            this.Kirjautumispaneeli.Controls.Add(this.salasanaLB);
            this.Kirjautumispaneeli.Controls.Add(this.KayttajaLB);
            this.Kirjautumispaneeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kirjautumispaneeli.Location = new System.Drawing.Point(12, 240);
            this.Kirjautumispaneeli.Name = "Kirjautumispaneeli";
            this.Kirjautumispaneeli.Size = new System.Drawing.Size(356, 173);
            this.Kirjautumispaneeli.TabIndex = 2;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaLB.ForeColor = System.Drawing.Color.SpringGreen;
            this.KayttajaLB.Location = new System.Drawing.Point(4, 25);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(96, 25);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjä:";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.ForeColor = System.Drawing.Color.SpringGreen;
            this.salasanaLB.Location = new System.Drawing.Point(4, 66);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(108, 25);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // textBoxKayttaja
            // 
            this.textBoxKayttaja.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxKayttaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKayttaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKayttaja.ForeColor = System.Drawing.Color.Peru;
            this.textBoxKayttaja.Location = new System.Drawing.Point(118, 22);
            this.textBoxKayttaja.Name = "textBoxKayttaja";
            this.textBoxKayttaja.Size = new System.Drawing.Size(221, 31);
            this.textBoxKayttaja.TabIndex = 2;
            // 
            // textBoxSalasana
            // 
            this.textBoxSalasana.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxSalasana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalasana.ForeColor = System.Drawing.Color.Peru;
            this.textBoxSalasana.Location = new System.Drawing.Point(118, 63);
            this.textBoxSalasana.Name = "textBoxSalasana";
            this.textBoxSalasana.Size = new System.Drawing.Size(221, 31);
            this.textBoxSalasana.TabIndex = 3;
            this.textBoxSalasana.UseSystemPasswordChar = true;
            this.textBoxSalasana.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonKirjaudu
            // 
            this.buttonKirjaudu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonKirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirjaudu.ForeColor = System.Drawing.Color.Crimson;
            this.buttonKirjaudu.Location = new System.Drawing.Point(9, 112);
            this.buttonKirjaudu.Name = "buttonKirjaudu";
            this.buttonKirjaudu.Size = new System.Drawing.Size(330, 46);
            this.buttonKirjaudu.TabIndex = 4;
            this.buttonKirjaudu.Text = "Kirjaudu";
            this.buttonKirjaudu.UseVisualStyleBackColor = false;
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(380, 426);
            this.Controls.Add(this.Kirjautumispaneeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kirjautumisikkuna";
            this.Text = "Kirjautumisikkuna";
            this.Load += new System.EventHandler(this.Kirjautumisikkuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Kirjautumispaneeli.ResumeLayout(false);
            this.Kirjautumispaneeli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Kirjautumispaneeli;
        private System.Windows.Forms.TextBox textBoxSalasana;
        private System.Windows.Forms.TextBox textBoxKayttaja;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.Button buttonKirjaudu;
    }
}