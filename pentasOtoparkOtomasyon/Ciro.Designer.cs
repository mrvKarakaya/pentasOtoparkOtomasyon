
namespace pentasOtoparkOtomasyon
{
    partial class Ciro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciro));
            this.dataGridViewVeriler = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVeriler
            // 
            this.dataGridViewVeriler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dataGridViewVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeriler.Location = new System.Drawing.Point(198, 306);
            this.dataGridViewVeriler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewVeriler.Name = "dataGridViewVeriler";
            this.dataGridViewVeriler.Size = new System.Drawing.Size(965, 406);
            this.dataGridViewVeriler.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(77, 60);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(180, 77);
            this.btnGeri.TabIndex = 48;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.lblToplam.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(1180, 76);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(98, 36);
            this.lblToplam.TabIndex = 49;
            this.lblToplam.Text = "label1";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(933, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 36);
            this.label2.TabIndex = 50;
            this.label2.Text = "TOPLAM :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.pictureBox1.Location = new System.Drawing.Point(913, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 77);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Ciro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1441, 830);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridViewVeriler);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ciro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CİRO";
            this.Load += new System.EventHandler(this.Ciro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVeriler;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}