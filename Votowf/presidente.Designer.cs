﻿namespace Votowf
{
    partial class presidente
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnleo = new System.Windows.Forms.Button();
            this.Btngon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_17_Buscar;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Votowf.Properties.Resources.Screenshot_2019_10_15_Junta_Central_Electoral;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnleo
            // 
            this.btnleo.BackgroundImage = global::Votowf.Properties.Resources.LEONELFERNANDEZ;
            this.btnleo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnleo.Location = new System.Drawing.Point(164, 152);
            this.btnleo.Name = "btnleo";
            this.btnleo.Size = new System.Drawing.Size(128, 125);
            this.btnleo.TabIndex = 2;
            this.btnleo.UseVisualStyleBackColor = true;
            this.btnleo.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btngon
            // 
            this.Btngon.BackgroundImage = global::Votowf.Properties.Resources.GONZALOCASTILLO;
            this.Btngon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btngon.Location = new System.Drawing.Point(12, 152);
            this.Btngon.Name = "Btngon";
            this.Btngon.Size = new System.Drawing.Size(128, 125);
            this.Btngon.TabIndex = 0;
            this.Btngon.UseVisualStyleBackColor = true;
            this.Btngon.Click += new System.EventHandler(this.button1_Click);
            // 
            // presidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnleo);
            this.Controls.Add(this.Btngon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "presidente";
            this.Text = "Pesidente";
            this.Load += new System.EventHandler(this.presidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btngon;
        private System.Windows.Forms.Button btnleo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}