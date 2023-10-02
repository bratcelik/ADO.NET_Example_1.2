namespace ADO.NET_Example
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lblListeDisiUrunToplam = new Label();
            lblListeUrunToplam = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 63);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Liste Dışı Ürün Toplam: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 115);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Liste Ürün Toplam: ";
            // 
            // lblListeDisiUrunToplam
            // 
            lblListeDisiUrunToplam.AutoSize = true;
            lblListeDisiUrunToplam.Location = new Point(236, 63);
            lblListeDisiUrunToplam.Name = "lblListeDisiUrunToplam";
            lblListeDisiUrunToplam.Size = new Size(15, 20);
            lblListeDisiUrunToplam.TabIndex = 2;
            lblListeDisiUrunToplam.Text = "*";
            // 
            // lblListeUrunToplam
            // 
            lblListeUrunToplam.AutoSize = true;
            lblListeUrunToplam.Location = new Point(236, 115);
            lblListeUrunToplam.Name = "lblListeUrunToplam";
            lblListeUrunToplam.Size = new Size(15, 20);
            lblListeUrunToplam.TabIndex = 3;
            lblListeUrunToplam.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 251);
            Controls.Add(lblListeUrunToplam);
            Controls.Add(lblListeDisiUrunToplam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblListeDisiUrunToplam;
        private Label lblListeUrunToplam;
    }
}