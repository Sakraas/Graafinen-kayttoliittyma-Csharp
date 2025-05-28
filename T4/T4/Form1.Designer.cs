namespace T4
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
            syntymaDT = new DateTimePicker();
            button1 = new Button();
            vuosiLB = new Label();
            kuukausiLB = new Label();
            paivaLB = new Label();
            sekuntiLB = new Label();
            minuuttiLB = new Label();
            tuntiLB = new Label();
            SuspendLayout();
            // 
            // syntymaDT
            // 
            syntymaDT.Location = new Point(12, 12);
            syntymaDT.Name = "syntymaDT";
            syntymaDT.Size = new Size(227, 23);
            syntymaDT.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(245, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 1;
            button1.Text = "Laske";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vuosiLB
            // 
            vuosiLB.AutoSize = true;
            vuosiLB.Location = new Point(12, 53);
            vuosiLB.Name = "vuosiLB";
            vuosiLB.Size = new Size(22, 15);
            vuosiLB.TabIndex = 2;
            vuosiLB.Text = "xxx";
            vuosiLB.Visible = false;
            // 
            // kuukausiLB
            // 
            kuukausiLB.AutoSize = true;
            kuukausiLB.Location = new Point(12, 86);
            kuukausiLB.Name = "kuukausiLB";
            kuukausiLB.Size = new Size(22, 15);
            kuukausiLB.TabIndex = 3;
            kuukausiLB.Text = "xxx";
            kuukausiLB.Visible = false;
            // 
            // paivaLB
            // 
            paivaLB.AutoSize = true;
            paivaLB.Location = new Point(12, 119);
            paivaLB.Name = "paivaLB";
            paivaLB.Size = new Size(22, 15);
            paivaLB.TabIndex = 4;
            paivaLB.Text = "xxx";
            paivaLB.Visible = false;
            // 
            // sekuntiLB
            // 
            sekuntiLB.AutoSize = true;
            sekuntiLB.Location = new Point(201, 119);
            sekuntiLB.Name = "sekuntiLB";
            sekuntiLB.Size = new Size(22, 15);
            sekuntiLB.TabIndex = 7;
            sekuntiLB.Text = "xxx";
            sekuntiLB.Visible = false;
            // 
            // minuuttiLB
            // 
            minuuttiLB.AutoSize = true;
            minuuttiLB.Location = new Point(201, 86);
            minuuttiLB.Name = "minuuttiLB";
            minuuttiLB.Size = new Size(22, 15);
            minuuttiLB.TabIndex = 6;
            minuuttiLB.Text = "xxx";
            minuuttiLB.Visible = false;
            // 
            // tuntiLB
            // 
            tuntiLB.AutoSize = true;
            tuntiLB.Location = new Point(201, 53);
            tuntiLB.Name = "tuntiLB";
            tuntiLB.Size = new Size(22, 15);
            tuntiLB.TabIndex = 5;
            tuntiLB.Text = "xxx";
            tuntiLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 159);
            Controls.Add(sekuntiLB);
            Controls.Add(minuuttiLB);
            Controls.Add(tuntiLB);
            Controls.Add(paivaLB);
            Controls.Add(kuukausiLB);
            Controls.Add(vuosiLB);
            Controls.Add(button1);
            Controls.Add(syntymaDT);
            Name = "Form1";
            Text = "Ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker syntymaDT;
        private Button button1;
        private Label vuosiLB;
        private Label kuukausiLB;
        private Label paivaLB;
        private Label sekuntiLB;
        private Label minuuttiLB;
        private Label tuntiLB;
    }
}
