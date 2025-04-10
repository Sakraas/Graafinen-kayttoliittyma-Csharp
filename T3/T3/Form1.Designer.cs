namespace T3
{
    partial class Nelilaskin
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
            lukuYksiTB = new TextBox();
            lukuKaksiTB = new TextBox();
            operaattoriCB = new ComboBox();
            label1 = new Label();
            vastausLB = new Label();
            laskeBT = new Button();
            SuspendLayout();
            // 
            // lukuYksiTB
            // 
            lukuYksiTB.Font = new Font("Segoe UI", 15.75F);
            lukuYksiTB.Location = new Point(12, 13);
            lukuYksiTB.Name = "lukuYksiTB";
            lukuYksiTB.Size = new Size(100, 35);
            lukuYksiTB.TabIndex = 0;
            // 
            // lukuKaksiTB
            // 
            lukuKaksiTB.Font = new Font("Segoe UI", 15.75F);
            lukuKaksiTB.Location = new Point(245, 13);
            lukuKaksiTB.Name = "lukuKaksiTB";
            lukuKaksiTB.Size = new Size(100, 35);
            lukuKaksiTB.TabIndex = 1;
            // 
            // operaattoriCB
            // 
            operaattoriCB.Font = new Font("Segoe UI", 15.75F);
            operaattoriCB.FormattingEnabled = true;
            operaattoriCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operaattoriCB.Location = new Point(118, 11);
            operaattoriCB.Name = "operaattoriCB";
            operaattoriCB.Size = new Size(121, 38);
            operaattoriCB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(351, 15);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Font = new Font("Segoe UI", 15.75F);
            vastausLB.Location = new Point(372, 15);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(43, 30);
            vastausLB.TabIndex = 4;
            vastausLB.Text = "xxx";
            vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            laskeBT.Location = new Point(12, 53);
            laskeBT.Name = "laskeBT";
            laskeBT.Size = new Size(75, 23);
            laskeBT.TabIndex = 5;
            laskeBT.Text = "Laske";
            laskeBT.UseVisualStyleBackColor = true;
            laskeBT.Click += laskeBT_Click;
            // 
            // Nelilaskin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 82);
            Controls.Add(laskeBT);
            Controls.Add(vastausLB);
            Controls.Add(label1);
            Controls.Add(operaattoriCB);
            Controls.Add(lukuKaksiTB);
            Controls.Add(lukuYksiTB);
            Name = "Nelilaskin";
            Text = "Yksinkertainen nelilaskin";
            Load += Nelilaskin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lukuYksiTB;
        private TextBox lukuKaksiTB;
        private ComboBox operaattoriCB;
        private Label label1;
        private Label vastausLB;
        private Button laskeBT;
    }
}
