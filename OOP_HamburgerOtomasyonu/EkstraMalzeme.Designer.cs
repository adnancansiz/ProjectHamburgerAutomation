
namespace OOP_HamburgerOtomasyonu
{
    partial class EkstraMalzeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkstraKaydet = new System.Windows.Forms.Button();
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraKaydet);
            this.groupBox1.Controls.Add(this.nudEkstraFiyat);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(664, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Bilgileri";
            // 
            // btnEkstraKaydet
            // 
            this.btnEkstraKaydet.Location = new System.Drawing.Point(176, 160);
            this.btnEkstraKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkstraKaydet.Name = "btnEkstraKaydet";
            this.btnEkstraKaydet.Size = new System.Drawing.Size(303, 42);
            this.btnEkstraKaydet.TabIndex = 3;
            this.btnEkstraKaydet.Text = "Kaydet";
            this.btnEkstraKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraKaydet.Click += new System.EventHandler(this.btnEkstraKaydet_Click);
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(176, 119);
            this.nudEkstraFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(303, 30);
            this.nudEkstraFiyat.TabIndex = 2;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(176, 65);
            this.txtEkstra.Margin = new System.Windows.Forms.Padding(4);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(301, 30);
            this.txtEkstra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Adı:";
            // 
            // EkstraMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 426);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EkstraMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EkstraMalzeme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraKaydet;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}