namespace T9
{
    partial class Lampotilamuunnin
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
            syottoTB = new TextBox();
            groupBox1 = new GroupBox();
            fahrenheitRB = new RadioButton();
            celsiusRB = new RadioButton();
            muunnaBT = new Button();
            vastausLB = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 15);
            label1.TabIndex = 0;
            label1.Text = "Syötä muunnettava arvo ja valitse arvon yksikkö";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Syötä asteet";
            // 
            // syottoTB
            // 
            syottoTB.Location = new Point(88, 71);
            syottoTB.Name = "syottoTB";
            syottoTB.Size = new Size(63, 23);
            syottoTB.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fahrenheitRB);
            groupBox1.Controls.Add(celsiusRB);
            groupBox1.Location = new Point(157, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 77);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Syötetty lämpötilayksikkö:";
            // 
            // fahrenheitRB
            // 
            fahrenheitRB.AutoSize = true;
            fahrenheitRB.Location = new Point(6, 47);
            fahrenheitRB.Name = "fahrenheitRB";
            fahrenheitRB.Size = new Size(81, 19);
            fahrenheitRB.TabIndex = 5;
            fahrenheitRB.Text = "Fahrenheit";
            fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // celsiusRB
            // 
            celsiusRB.AutoSize = true;
            celsiusRB.Checked = true;
            celsiusRB.Location = new Point(6, 22);
            celsiusRB.Name = "celsiusRB";
            celsiusRB.Size = new Size(62, 19);
            celsiusRB.TabIndex = 4;
            celsiusRB.TabStop = true;
            celsiusRB.Text = "Celsius";
            celsiusRB.UseVisualStyleBackColor = true;
            // 
            // muunnaBT
            // 
            muunnaBT.Location = new Point(323, 58);
            muunnaBT.Name = "muunnaBT";
            muunnaBT.Size = new Size(80, 46);
            muunnaBT.TabIndex = 4;
            muunnaBT.Text = "Muunna";
            muunnaBT.UseVisualStyleBackColor = true;
            muunnaBT.Click += muunnaBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(157, 136);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(22, 15);
            vastausLB.TabIndex = 5;
            vastausLB.Text = "xxx";
            vastausLB.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 136);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Vastaus:";
            // 
            // Lampotilamuunnin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 181);
            Controls.Add(label3);
            Controls.Add(vastausLB);
            Controls.Add(muunnaBT);
            Controls.Add(groupBox1);
            Controls.Add(syottoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lampotilamuunnin";
            Text = "Lämpötilamuunnin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox syottoTB;
        private GroupBox groupBox1;
        private RadioButton fahrenheitRB;
        private RadioButton celsiusRB;
        private Button muunnaBT;
        private Label vastausLB;
        private Label label3;
    }
}
