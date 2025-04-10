namespace T2
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
            SyottoKenttaTB = new TextBox();
            TulostusLB = new Label();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Anna tulostettava teksti";
            // 
            // SyottoKenttaTB
            // 
            SyottoKenttaTB.Location = new Point(171, 23);
            SyottoKenttaTB.Name = "SyottoKenttaTB";
            SyottoKenttaTB.Size = new Size(431, 23);
            SyottoKenttaTB.TabIndex = 1;
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Location = new Point(34, 62);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(25, 15);
            TulostusLB.TabIndex = 2;
            TulostusLB.Text = "xxx";
            TulostusLB.Visible = false;
            // 
            // TulostaBT
            // 
            TulostaBT.Location = new Point(34, 199);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(75, 23);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 234);
            Controls.Add(TulostaBT);
            Controls.Add(TulostusLB);
            Controls.Add(SyottoKenttaTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Harjoitus2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SyottoKenttaTB;
        private Label TulostusLB;
        private Button TulostaBT;
    }
}
