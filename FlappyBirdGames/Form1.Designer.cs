
namespace FlappyBirdGames
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbZemin = new System.Windows.Forms.PictureBox();
            this.pbBoru4 = new System.Windows.Forms.PictureBox();
            this.pbKus = new System.Windows.Forms.PictureBox();
            this.pbBoru3 = new System.Windows.Forms.PictureBox();
            this.pbBoru2 = new System.Windows.Forms.PictureBox();
            this.pbBoru1 = new System.Windows.Forms.PictureBox();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbZemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbZemin
            // 
            this.pbZemin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbZemin.Image = global::FlappyBirdGames.Properties.Resources.ground;
            this.pbZemin.Location = new System.Drawing.Point(0, 381);
            this.pbZemin.Name = "pbZemin";
            this.pbZemin.Size = new System.Drawing.Size(810, 64);
            this.pbZemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZemin.TabIndex = 0;
            this.pbZemin.TabStop = false;
            // 
            // pbBoru4
            // 
            this.pbBoru4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbBoru4.Image = global::FlappyBirdGames.Properties.Resources.pipe;
            this.pbBoru4.Location = new System.Drawing.Point(690, 249);
            this.pbBoru4.Name = "pbBoru4";
            this.pbBoru4.Size = new System.Drawing.Size(100, 137);
            this.pbBoru4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoru4.TabIndex = 0;
            this.pbBoru4.TabStop = false;
            // 
            // pbKus
            // 
            this.pbKus.Image = ((System.Drawing.Image)(resources.GetObject("pbKus.Image")));
            this.pbKus.Location = new System.Drawing.Point(12, 210);
            this.pbKus.Name = "pbKus";
            this.pbKus.Size = new System.Drawing.Size(64, 55);
            this.pbKus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKus.TabIndex = 0;
            this.pbKus.TabStop = false;
            // 
            // pbBoru3
            // 
            this.pbBoru3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbBoru3.Image = global::FlappyBirdGames.Properties.Resources.pipedown;
            this.pbBoru3.Location = new System.Drawing.Point(634, -1);
            this.pbBoru3.Name = "pbBoru3";
            this.pbBoru3.Size = new System.Drawing.Size(100, 118);
            this.pbBoru3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoru3.TabIndex = 0;
            this.pbBoru3.TabStop = false;
            // 
            // pbBoru2
            // 
            this.pbBoru2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbBoru2.Image = global::FlappyBirdGames.Properties.Resources.pipe;
            this.pbBoru2.Location = new System.Drawing.Point(307, 307);
            this.pbBoru2.Name = "pbBoru2";
            this.pbBoru2.Size = new System.Drawing.Size(100, 79);
            this.pbBoru2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoru2.TabIndex = 0;
            this.pbBoru2.TabStop = false;
            // 
            // pbBoru1
            // 
            this.pbBoru1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbBoru1.Image = global::FlappyBirdGames.Properties.Resources.pipedown;
            this.pbBoru1.Location = new System.Drawing.Point(328, -1);
            this.pbBoru1.Name = "pbBoru1";
            this.pbBoru1.Size = new System.Drawing.Size(100, 126);
            this.pbBoru1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoru1.TabIndex = 0;
            this.pbBoru1.TabStop = false;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 20;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(261, 410);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(186, 35);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "skor-";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 445);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbBoru4);
            this.Controls.Add(this.pbBoru3);
            this.Controls.Add(this.pbBoru2);
            this.Controls.Add(this.pbBoru1);
            this.Controls.Add(this.pbKus);
            this.Controls.Add(this.pbZemin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FlappyBird 1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbZemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoru1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbZemin;
        private System.Windows.Forms.PictureBox pbBoru4;
        private System.Windows.Forms.PictureBox pbKus;
        private System.Windows.Forms.PictureBox pbBoru3;
        private System.Windows.Forms.PictureBox pbBoru2;
        private System.Windows.Forms.PictureBox pbBoru1;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Label lblScore;
    }
}

