namespace T10
{
    partial class BMI
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
            pituusTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            painoTB = new TextBox();
            bmiLB = new Label();
            laskeBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Syötä tarvittavat arvot";
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(12, 27);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(100, 23);
            pituusTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 30);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "pituus senttimetreinä";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 59);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 4;
            label3.Text = "paino kilogrammoina";
            // 
            // painoTB
            // 
            painoTB.Location = new Point(12, 56);
            painoTB.Name = "painoTB";
            painoTB.Size = new Size(100, 23);
            painoTB.TabIndex = 3;
            // 
            // bmiLB
            // 
            bmiLB.AutoSize = true;
            bmiLB.Location = new Point(12, 119);
            bmiLB.Name = "bmiLB";
            bmiLB.Size = new Size(22, 15);
            bmiLB.TabIndex = 5;
            bmiLB.Text = "xxx";
            bmiLB.Visible = false;
            // 
            // laskeBT
            // 
            laskeBT.Location = new Point(12, 85);
            laskeBT.Name = "laskeBT";
            laskeBT.Size = new Size(225, 31);
            laskeBT.TabIndex = 6;
            laskeBT.Text = "Laske painoindeksi";
            laskeBT.UseVisualStyleBackColor = true;
            laskeBT.Click += laskeBT_Click;
            // 
            // BMI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 162);
            Controls.Add(laskeBT);
            Controls.Add(bmiLB);
            Controls.Add(label3);
            Controls.Add(painoTB);
            Controls.Add(label2);
            Controls.Add(pituusTB);
            Controls.Add(label1);
            Name = "BMI";
            Text = "BMI-laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox pituusTB;
        private Label label2;
        private Label label3;
        private TextBox painoTB;
        private Label bmiLB;
        private Button laskeBT;
    }
}
