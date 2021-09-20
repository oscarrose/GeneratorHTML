
namespace GeneratorHTML
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.bodyleft = new System.Windows.Forms.Panel();
            this.bodytop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAboutyou = new System.Windows.Forms.Button();
            this.buttonhobbies = new System.Windows.Forms.Button();
            this.buttonyoutube = new System.Windows.Forms.Button();
            this.buttonseries = new System.Windows.Forms.Button();
            this.buttoncontacts = new System.Windows.Forms.Button();
            this.bodycontenier = new System.Windows.Forms.Panel();
            this.bodyleft.SuspendLayout();
            this.bodytop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyleft
            // 
            this.bodyleft.BackColor = System.Drawing.Color.Black;
            this.bodyleft.Controls.Add(this.buttoncontacts);
            this.bodyleft.Controls.Add(this.buttonseries);
            this.bodyleft.Controls.Add(this.buttonyoutube);
            this.bodyleft.Controls.Add(this.buttonhobbies);
            this.bodyleft.Controls.Add(this.buttonAboutyou);
            this.bodyleft.Controls.Add(this.label1);
            this.bodyleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bodyleft.Location = new System.Drawing.Point(0, 0);
            this.bodyleft.Name = "bodyleft";
            this.bodyleft.Size = new System.Drawing.Size(233, 763);
            this.bodyleft.TabIndex = 0;
            // 
            // bodytop
            // 
            this.bodytop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bodytop.Controls.Add(this.pictureBox2);
            this.bodytop.Controls.Add(this.pictureBox1);
            this.bodytop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodytop.Location = new System.Drawing.Point(233, 0);
            this.bodytop.Name = "bodytop";
            this.bodytop.Size = new System.Drawing.Size(1078, 41);
            this.bodytop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GeneratorHTML";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1030, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(979, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonAboutyou
            // 
            this.buttonAboutyou.BackColor = System.Drawing.Color.Black;
            this.buttonAboutyou.FlatAppearance.BorderSize = 0;
            this.buttonAboutyou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutyou.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutyou.ForeColor = System.Drawing.Color.White;
            this.buttonAboutyou.Location = new System.Drawing.Point(-2, 76);
            this.buttonAboutyou.Name = "buttonAboutyou";
            this.buttonAboutyou.Size = new System.Drawing.Size(224, 72);
            this.buttonAboutyou.TabIndex = 1;
            this.buttonAboutyou.Text = "About you";
            this.buttonAboutyou.UseVisualStyleBackColor = false;
            // 
            // buttonhobbies
            // 
            this.buttonhobbies.BackColor = System.Drawing.Color.Black;
            this.buttonhobbies.FlatAppearance.BorderSize = 0;
            this.buttonhobbies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhobbies.ForeColor = System.Drawing.Color.Transparent;
            this.buttonhobbies.Location = new System.Drawing.Point(-2, 181);
            this.buttonhobbies.Name = "buttonhobbies";
            this.buttonhobbies.Size = new System.Drawing.Size(224, 72);
            this.buttonhobbies.TabIndex = 1;
            this.buttonhobbies.Text = "Hobbies";
            this.buttonhobbies.UseVisualStyleBackColor = false;
            // 
            // buttonyoutube
            // 
            this.buttonyoutube.BackColor = System.Drawing.Color.Black;
            this.buttonyoutube.FlatAppearance.BorderSize = 0;
            this.buttonyoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonyoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonyoutube.ForeColor = System.Drawing.Color.Transparent;
            this.buttonyoutube.Location = new System.Drawing.Point(-2, 288);
            this.buttonyoutube.Name = "buttonyoutube";
            this.buttonyoutube.Size = new System.Drawing.Size(224, 72);
            this.buttonyoutube.TabIndex = 1;
            this.buttonyoutube.Text = "Youtube favorites";
            this.buttonyoutube.UseVisualStyleBackColor = false;
            // 
            // buttonseries
            // 
            this.buttonseries.BackColor = System.Drawing.Color.Black;
            this.buttonseries.FlatAppearance.BorderSize = 0;
            this.buttonseries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonseries.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonseries.ForeColor = System.Drawing.Color.Transparent;
            this.buttonseries.Location = new System.Drawing.Point(-2, 391);
            this.buttonseries.Name = "buttonseries";
            this.buttonseries.Size = new System.Drawing.Size(224, 72);
            this.buttonseries.TabIndex = 1;
            this.buttonseries.Text = "Favorite series";
            this.buttonseries.UseVisualStyleBackColor = false;
            // 
            // buttoncontacts
            // 
            this.buttoncontacts.BackColor = System.Drawing.Color.Black;
            this.buttoncontacts.FlatAppearance.BorderSize = 0;
            this.buttoncontacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncontacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncontacts.ForeColor = System.Drawing.Color.Transparent;
            this.buttoncontacts.Location = new System.Drawing.Point(-2, 490);
            this.buttoncontacts.Name = "buttoncontacts";
            this.buttoncontacts.Size = new System.Drawing.Size(224, 72);
            this.buttoncontacts.TabIndex = 1;
            this.buttoncontacts.Text = "Contacts";
            this.buttoncontacts.UseVisualStyleBackColor = false;
            // 
            // bodycontenier
            // 
            this.bodycontenier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodycontenier.Location = new System.Drawing.Point(233, 41);
            this.bodycontenier.Name = "bodycontenier";
            this.bodycontenier.Size = new System.Drawing.Size(1078, 722);
            this.bodycontenier.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 763);
            this.Controls.Add(this.bodycontenier);
            this.Controls.Add(this.bodytop);
            this.Controls.Add(this.bodyleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bodyleft.ResumeLayout(false);
            this.bodyleft.PerformLayout();
            this.bodytop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bodytop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttoncontacts;
        private System.Windows.Forms.Button buttonseries;
        private System.Windows.Forms.Button buttonyoutube;
        private System.Windows.Forms.Button buttonhobbies;
        private System.Windows.Forms.Button buttonAboutyou;
        private System.Windows.Forms.Panel bodycontenier;
    }
}

