﻿namespace Votowf
{
    partial class Julio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreto = new System.Windows.Forms.Button();
            this.btncont = new System.Windows.Forms.Button();
            this.btncongon1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_15_Confirmar;
            this.pictureBox1.Location = new System.Drawing.Point(204, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // btnreto
            // 
            this.btnreto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnreto.BackColor = System.Drawing.Color.Red;
            this.btnreto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreto.Location = new System.Drawing.Point(77, 148);
            this.btnreto.Name = "btnreto";
            this.btnreto.Size = new System.Drawing.Size(121, 37);
            this.btnreto.TabIndex = 44;
            this.btnreto.Text = "Retornar";
            this.btnreto.UseVisualStyleBackColor = false;
            this.btnreto.Click += new System.EventHandler(this.btnreto_Click);
            this.btnreto.Enter += new System.EventHandler(this.btnreto_Enter);
            // 
            // btncont
            // 
            this.btncont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncont.BackColor = System.Drawing.Color.Lime;
            this.btncont.Location = new System.Drawing.Point(431, 148);
            this.btncont.Name = "btncont";
            this.btncont.Size = new System.Drawing.Size(121, 37);
            this.btncont.TabIndex = 43;
            this.btncont.Text = "Continuar";
            this.btncont.UseVisualStyleBackColor = false;
            this.btncont.Click += new System.EventHandler(this.btncont_Click);
            // 
            // btncongon1
            // 
            this.btncongon1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncongon1.BackgroundImage = global::Votowf.Properties.Resources._24;
            this.btncongon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncongon1.Location = new System.Drawing.Point(77, 247);
            this.btncongon1.Name = "btncongon1";
            this.btncongon1.Size = new System.Drawing.Size(475, 313);
            this.btncongon1.TabIndex = 42;
            this.btncongon1.UseVisualStyleBackColor = true;
            this.btncongon1.Click += new System.EventHandler(this.btncongon1_Click);
            this.btncongon1.Enter += new System.EventHandler(this.btncongon1_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_17_Buscar_1_;
            this.pictureBox3.Location = new System.Drawing.Point(77, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(475, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Julio Holguin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Votowf.Properties.Resources.logonuevo1;
            this.pictureBox2.Location = new System.Drawing.Point(43, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(545, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // Julio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 585);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnreto);
            this.Controls.Add(this.btncont);
            this.Controls.Add(this.btncongon1);
            this.Name = "Julio";
            this.Text = "Julio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnreto;
        private System.Windows.Forms.Button btncont;
        private System.Windows.Forms.Button btncongon1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}