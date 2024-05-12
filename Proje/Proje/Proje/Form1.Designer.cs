namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenel = new System.Windows.Forms.Button();
            this.btnTrh = new System.Windows.Forms.Button();
            this.btnbiyo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenel
            // 
            this.btnGenel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnGenel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenel.BackgroundImage")));
            this.btnGenel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenel.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenel.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenel.Location = new System.Drawing.Point(271, 103);
            this.btnGenel.Name = "btnGenel";
            this.btnGenel.Size = new System.Drawing.Size(415, 57);
            this.btnGenel.TabIndex = 1;
            this.btnGenel.Text = "Genel Kültür";
            this.btnGenel.UseVisualStyleBackColor = false;
            this.btnGenel.Click += new System.EventHandler(this.btnGenel_Click);
            // 
            // btnTrh
            // 
            this.btnTrh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnTrh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrh.BackgroundImage")));
            this.btnTrh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrh.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrh.ForeColor = System.Drawing.Color.DeepPink;
            this.btnTrh.Location = new System.Drawing.Point(271, 223);
            this.btnTrh.Name = "btnTrh";
            this.btnTrh.Size = new System.Drawing.Size(415, 57);
            this.btnTrh.TabIndex = 2;
            this.btnTrh.Text = "TARİH";
            this.btnTrh.UseVisualStyleBackColor = false;
            this.btnTrh.Click += new System.EventHandler(this.btnTrh_Click);
            // 
            // btnbiyo
            // 
            this.btnbiyo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnbiyo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbiyo.BackgroundImage")));
            this.btnbiyo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbiyo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbiyo.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbiyo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnbiyo.Location = new System.Drawing.Point(271, 333);
            this.btnbiyo.Name = "btnbiyo";
            this.btnbiyo.Size = new System.Drawing.Size(415, 57);
            this.btnbiyo.TabIndex = 3;
            this.btnbiyo.Text = "Biyoloji";
            this.btnbiyo.UseVisualStyleBackColor = false;
            this.btnbiyo.Click += new System.EventHandler(this.btnbiyo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(975, 460);
            this.Controls.Add(this.btnbiyo);
            this.Controls.Add(this.btnTrh);
            this.Controls.Add(this.btnGenel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenel;
        private System.Windows.Forms.Button btnTrh;
        private System.Windows.Forms.Button btnbiyo;
    }
}

