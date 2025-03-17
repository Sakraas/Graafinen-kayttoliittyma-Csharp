namespace Hotellijarjestelma
{
    partial class HuoneidenHallinta
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
            this.LabelVaraustenHallinta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTyyppi = new System.Windows.Forms.Label();
            this.labelHuone = new System.Windows.Forms.Label();
            this.comboBoxHuoneTyyppi = new System.Windows.Forms.ComboBox();
            this.textBoxHuoneenNro = new System.Windows.Forms.TextBox();
            this.textBoxPuhelin = new System.Windows.Forms.TextBox();
            this.groupBoxKyllaEi = new System.Windows.Forms.GroupBox();
            this.radioButtonKylla = new System.Windows.Forms.RadioButton();
            this.radioButtonEi = new System.Windows.Forms.RadioButton();
            this.buttonTyhjennaHuoneKentat = new System.Windows.Forms.Button();
            this.buttonPoistaHuone = new System.Windows.Forms.Button();
            this.buttonMuokkaaHuonetta = new System.Windows.Forms.Button();
            this.buttonUusiHuone = new System.Windows.Forms.Button();
            this.dataVaraustenHallinta = new System.Windows.Forms.DataGridView();
            this.groupBoxKyllaEi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraustenHallinta)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelVaraustenHallinta
            // 
            this.LabelVaraustenHallinta.BackColor = System.Drawing.Color.Teal;
            this.LabelVaraustenHallinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVaraustenHallinta.ForeColor = System.Drawing.Color.Aqua;
            this.LabelVaraustenHallinta.Location = new System.Drawing.Point(-1, -1);
            this.LabelVaraustenHallinta.Name = "LabelVaraustenHallinta";
            this.LabelVaraustenHallinta.Size = new System.Drawing.Size(807, 96);
            this.LabelVaraustenHallinta.TabIndex = 2;
            this.LabelVaraustenHallinta.Text = "Huoneiden hallinta";
            this.LabelVaraustenHallinta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(80, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vapaa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(68, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Puhelin:";
            // 
            // labelTyyppi
            // 
            this.labelTyyppi.AutoSize = true;
            this.labelTyyppi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTyyppi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTyyppi.ForeColor = System.Drawing.Color.Aqua;
            this.labelTyyppi.Location = new System.Drawing.Point(16, 149);
            this.labelTyyppi.Name = "labelTyyppi";
            this.labelTyyppi.Size = new System.Drawing.Size(150, 25);
            this.labelTyyppi.TabIndex = 26;
            this.labelTyyppi.Text = "Huonetyyppi:";
            // 
            // labelHuone
            // 
            this.labelHuone.AutoSize = true;
            this.labelHuone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHuone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuone.ForeColor = System.Drawing.Color.Aqua;
            this.labelHuone.Location = new System.Drawing.Point(12, 112);
            this.labelHuone.Name = "labelHuone";
            this.labelHuone.Size = new System.Drawing.Size(154, 25);
            this.labelHuone.TabIndex = 25;
            this.labelHuone.Text = "Huoneen nro:";
            // 
            // comboBoxHuoneTyyppi
            // 
            this.comboBoxHuoneTyyppi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHuoneTyyppi.FormattingEnabled = true;
            this.comboBoxHuoneTyyppi.Location = new System.Drawing.Point(172, 146);
            this.comboBoxHuoneTyyppi.Name = "comboBoxHuoneTyyppi";
            this.comboBoxHuoneTyyppi.Size = new System.Drawing.Size(225, 33);
            this.comboBoxHuoneTyyppi.TabIndex = 30;
            // 
            // textBoxHuoneenNro
            // 
            this.textBoxHuoneenNro.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxHuoneenNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuoneenNro.Location = new System.Drawing.Point(172, 109);
            this.textBoxHuoneenNro.Name = "textBoxHuoneenNro";
            this.textBoxHuoneenNro.Size = new System.Drawing.Size(225, 31);
            this.textBoxHuoneenNro.TabIndex = 29;
            // 
            // textBoxPuhelin
            // 
            this.textBoxPuhelin.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxPuhelin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuhelin.Location = new System.Drawing.Point(172, 183);
            this.textBoxPuhelin.Name = "textBoxPuhelin";
            this.textBoxPuhelin.Size = new System.Drawing.Size(225, 31);
            this.textBoxPuhelin.TabIndex = 31;
            // 
            // groupBoxKyllaEi
            // 
            this.groupBoxKyllaEi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxKyllaEi.Controls.Add(this.radioButtonEi);
            this.groupBoxKyllaEi.Controls.Add(this.radioButtonKylla);
            this.groupBoxKyllaEi.ForeColor = System.Drawing.Color.BurlyWood;
            this.groupBoxKyllaEi.Location = new System.Drawing.Point(172, 241);
            this.groupBoxKyllaEi.Name = "groupBoxKyllaEi";
            this.groupBoxKyllaEi.Size = new System.Drawing.Size(225, 51);
            this.groupBoxKyllaEi.TabIndex = 32;
            this.groupBoxKyllaEi.TabStop = false;
            this.groupBoxKyllaEi.Text = "Vapaa";
            // 
            // radioButtonKylla
            // 
            this.radioButtonKylla.AutoSize = true;
            this.radioButtonKylla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKylla.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioButtonKylla.Location = new System.Drawing.Point(6, 14);
            this.radioButtonKylla.Name = "radioButtonKylla";
            this.radioButtonKylla.Size = new System.Drawing.Size(97, 29);
            this.radioButtonKylla.TabIndex = 1;
            this.radioButtonKylla.TabStop = true;
            this.radioButtonKylla.Text = "KYLLÄ";
            this.radioButtonKylla.UseVisualStyleBackColor = true;
            // 
            // radioButtonEi
            // 
            this.radioButtonEi.AutoSize = true;
            this.radioButtonEi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEi.ForeColor = System.Drawing.Color.Crimson;
            this.radioButtonEi.Location = new System.Drawing.Point(159, 14);
            this.radioButtonEi.Name = "radioButtonEi";
            this.radioButtonEi.Size = new System.Drawing.Size(49, 29);
            this.radioButtonEi.TabIndex = 2;
            this.radioButtonEi.TabStop = true;
            this.radioButtonEi.Text = "EI";
            this.radioButtonEi.UseVisualStyleBackColor = true;
            // 
            // buttonTyhjennaHuoneKentat
            // 
            this.buttonTyhjennaHuoneKentat.BackColor = System.Drawing.Color.Teal;
            this.buttonTyhjennaHuoneKentat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTyhjennaHuoneKentat.ForeColor = System.Drawing.Color.Aqua;
            this.buttonTyhjennaHuoneKentat.Location = new System.Drawing.Point(224, 357);
            this.buttonTyhjennaHuoneKentat.Name = "buttonTyhjennaHuoneKentat";
            this.buttonTyhjennaHuoneKentat.Size = new System.Drawing.Size(173, 29);
            this.buttonTyhjennaHuoneKentat.TabIndex = 40;
            this.buttonTyhjennaHuoneKentat.Text = "Tyhjennä kentät";
            this.buttonTyhjennaHuoneKentat.UseVisualStyleBackColor = false;
            // 
            // buttonPoistaHuone
            // 
            this.buttonPoistaHuone.BackColor = System.Drawing.Color.Teal;
            this.buttonPoistaHuone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoistaHuone.ForeColor = System.Drawing.Color.Aqua;
            this.buttonPoistaHuone.Location = new System.Drawing.Point(316, 322);
            this.buttonPoistaHuone.Name = "buttonPoistaHuone";
            this.buttonPoistaHuone.Size = new System.Drawing.Size(81, 29);
            this.buttonPoistaHuone.TabIndex = 39;
            this.buttonPoistaHuone.Text = "Poista";
            this.buttonPoistaHuone.UseVisualStyleBackColor = false;
            // 
            // buttonMuokkaaHuonetta
            // 
            this.buttonMuokkaaHuonetta.BackColor = System.Drawing.Color.Teal;
            this.buttonMuokkaaHuonetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuokkaaHuonetta.ForeColor = System.Drawing.Color.Aqua;
            this.buttonMuokkaaHuonetta.Location = new System.Drawing.Point(207, 322);
            this.buttonMuokkaaHuonetta.Name = "buttonMuokkaaHuonetta";
            this.buttonMuokkaaHuonetta.Size = new System.Drawing.Size(103, 29);
            this.buttonMuokkaaHuonetta.TabIndex = 38;
            this.buttonMuokkaaHuonetta.Text = "Muokkaa";
            this.buttonMuokkaaHuonetta.UseVisualStyleBackColor = false;
            // 
            // buttonUusiHuone
            // 
            this.buttonUusiHuone.BackColor = System.Drawing.Color.Teal;
            this.buttonUusiHuone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUusiHuone.ForeColor = System.Drawing.Color.Aqua;
            this.buttonUusiHuone.Location = new System.Drawing.Point(41, 322);
            this.buttonUusiHuone.Name = "buttonUusiHuone";
            this.buttonUusiHuone.Size = new System.Drawing.Size(160, 29);
            this.buttonUusiHuone.TabIndex = 37;
            this.buttonUusiHuone.Text = "Lisää uusi huone";
            this.buttonUusiHuone.UseVisualStyleBackColor = false;
            // 
            // dataVaraustenHallinta
            // 
            this.dataVaraustenHallinta.BackgroundColor = System.Drawing.Color.Teal;
            this.dataVaraustenHallinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVaraustenHallinta.Location = new System.Drawing.Point(403, 98);
            this.dataVaraustenHallinta.Name = "dataVaraustenHallinta";
            this.dataVaraustenHallinta.Size = new System.Drawing.Size(387, 342);
            this.dataVaraustenHallinta.TabIndex = 41;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataVaraustenHallinta);
            this.Controls.Add(this.buttonTyhjennaHuoneKentat);
            this.Controls.Add(this.buttonPoistaHuone);
            this.Controls.Add(this.buttonMuokkaaHuonetta);
            this.Controls.Add(this.buttonUusiHuone);
            this.Controls.Add(this.groupBoxKyllaEi);
            this.Controls.Add(this.textBoxPuhelin);
            this.Controls.Add(this.comboBoxHuoneTyyppi);
            this.Controls.Add(this.textBoxHuoneenNro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTyyppi);
            this.Controls.Add(this.labelHuone);
            this.Controls.Add(this.LabelVaraustenHallinta);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            this.groupBoxKyllaEi.ResumeLayout(false);
            this.groupBoxKyllaEi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraustenHallinta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelVaraustenHallinta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTyyppi;
        private System.Windows.Forms.Label labelHuone;
        private System.Windows.Forms.ComboBox comboBoxHuoneTyyppi;
        private System.Windows.Forms.TextBox textBoxHuoneenNro;
        private System.Windows.Forms.TextBox textBoxPuhelin;
        private System.Windows.Forms.GroupBox groupBoxKyllaEi;
        private System.Windows.Forms.RadioButton radioButtonEi;
        private System.Windows.Forms.RadioButton radioButtonKylla;
        private System.Windows.Forms.Button buttonTyhjennaHuoneKentat;
        private System.Windows.Forms.Button buttonPoistaHuone;
        private System.Windows.Forms.Button buttonMuokkaaHuonetta;
        private System.Windows.Forms.Button buttonUusiHuone;
        private System.Windows.Forms.DataGridView dataVaraustenHallinta;
    }
}