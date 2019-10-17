namespace Votowf
{
    partial class Ramona
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
            this.btnreto = new System.Windows.Forms.Button();
            this.btncont = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncongon1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreto
            // 
            this.btnreto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnreto.BackColor = System.Drawing.Color.Red;
            this.btnreto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreto.Location = new System.Drawing.Point(83, 148);
            this.btnreto.Name = "btnreto";
            this.btnreto.Size = new System.Drawing.Size(121, 37);
            this.btnreto.TabIndex = 38;
            this.btnreto.Text = "Retornar";
            this.btnreto.UseVisualStyleBackColor = false;
            this.btnreto.Click += new System.EventHandler(this.btnreto_Click);
            // 
            // btncont
            // 
            this.btncont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncont.BackColor = System.Drawing.Color.Lime;
            this.btncont.Location = new System.Drawing.Point(437, 148);
            this.btncont.Name = "btncont";
            this.btncont.Size = new System.Drawing.Size(121, 37);
            this.btncont.TabIndex = 37;
            this.btncont.Text = "Continuar";
            this.btncont.UseVisualStyleBackColor = false;
            this.btncont.Click += new System.EventHandler(this.btncont_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_17_Buscar_1_;
            this.pictureBox3.Location = new System.Drawing.Point(83, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(475, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_15_Junta_Central_Electoral;
            this.pictureBox2.Location = new System.Drawing.Point(25, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_15_Confirmar;
            this.pictureBox1.Location = new System.Drawing.Point(210, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btncongon1
            // 
            this.btncongon1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncongon1.BackgroundImage = global::Votowf.Properties.Resources._20;
            this.btncongon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncongon1.Location = new System.Drawing.Point(83, 247);
            this.btncongon1.Name = "btncongon1";
            this.btncongon1.Size = new System.Drawing.Size(475, 312);
            this.btncongon1.TabIndex = 36;
            this.btncongon1.UseVisualStyleBackColor = true;
            this.btncongon1.Click += new System.EventHandler(this.btncongon1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ramona Tejada";
            // 
            // Ramona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnreto);
            this.Controls.Add(this.btncont);
            this.Controls.Add(this.btncongon1);
            this.Name = "Ramona";
            this.Text = "Ramona";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnreto;
        private System.Windows.Forms.Button btncont;
        private System.Windows.Forms.Button btncongon1;
        private System.Windows.Forms.Label label3;
    }
}