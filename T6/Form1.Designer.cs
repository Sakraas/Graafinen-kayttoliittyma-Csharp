namespace T6
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            SalasanaOikeinPanel = new Panel();
            label3 = new Label();
            VirheviestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(SalasanaOikeinPanel);
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI", 18F);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(613, 182);
            SalasanaPanel.TabIndex = 0;
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(label3);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(613, 182);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            SalasanaOikeinPanel.Paint += SalasanaOikeinPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(574, 80);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleni";
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.Location = new Point(12, 106);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(70, 32);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(12, 58);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(131, 45);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(327, 61);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(242, 39);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(327, 16);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(242, 39);
            KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 64);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus:";
            label1.Click += label1_Click;
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 182);
            Controls.Add(SalasanaPanel);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label label2;
        private Label label1;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Panel SalasanaOikeinPanel;
        private Label VirheviestiLB;
        private Label label3;
    }
}
