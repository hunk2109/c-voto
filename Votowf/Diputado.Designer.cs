﻿namespace Votowf
{
    partial class Diputado
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
            this.btncan3 = new System.Windows.Forms.Button();
            this.btncan2 = new System.Windows.Forms.Button();
            this.btnca1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncan3
            // 
            this.btncan3.BackgroundImage = global::Votowf.Properties.Resources._17;
            this.btncan3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncan3.Location = new System.Drawing.Point(317, 124);
            this.btncan3.Name = "btncan3";
            this.btncan3.Size = new System.Drawing.Size(128, 125);
            this.btncan3.TabIndex = 4;
            this.btncan3.UseVisualStyleBackColor = true;
            this.btncan3.Click += new System.EventHandler(this.btncan3_Click);
            // 
            // btncan2
            // 
            this.btncan2.BackgroundImage = global::Votowf.Properties.Resources._19;
            this.btncan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncan2.Location = new System.Drawing.Point(166, 124);
            this.btncan2.Name = "btncan2";
            this.btncan2.Size = new System.Drawing.Size(128, 125);
            this.btncan2.TabIndex = 3;
            this.btncan2.UseVisualStyleBackColor = true;
            this.btncan2.Click += new System.EventHandler(this.btncan2_Click);
            // 
            // btnca1
            // 
            this.btnca1.BackgroundImage = global::Votowf.Properties.Resources._9;
            this.btnca1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnca1.Location = new System.Drawing.Point(12, 124);
            this.btnca1.Name = "btnca1";
            this.btnca1.Size = new System.Drawing.Size(128, 125);
            this.btnca1.TabIndex = 2;
            this.btnca1.UseVisualStyleBackColor = true;
            this.btnca1.Click += new System.EventHandler(this.btnca1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_15_Junta_Central_Electoral;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_17_Confirmar;
            this.pictureBox2.Location = new System.Drawing.Point(12, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Diputado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncan3);
            this.Controls.Add(this.btncan2);
            this.Controls.Add(this.btnca1);
            this.Name = "Diputado";
            this.Text = "Diputado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnca1;
        private System.Windows.Forms.Button btncan2;
        private System.Windows.Forms.Button btncan3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}