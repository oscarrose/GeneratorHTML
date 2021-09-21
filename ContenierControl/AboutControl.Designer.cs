
namespace GeneratorHTML.ContenierControl
{
    partial class AboutControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddabout = new System.Windows.Forms.Button();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.gridAbout = new System.Windows.Forms.DataGridView();
            this.buttonEditContent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "About you";
            // 
            // buttonAddabout
            // 
            this.buttonAddabout.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddabout.FlatAppearance.BorderSize = 0;
            this.buttonAddabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddabout.Location = new System.Drawing.Point(740, 47);
            this.buttonAddabout.Name = "buttonAddabout";
            this.buttonAddabout.Size = new System.Drawing.Size(152, 51);
            this.buttonAddabout.TabIndex = 2;
            this.buttonAddabout.Text = "Add content";
            this.buttonAddabout.UseVisualStyleBackColor = false;
            // 
            // buttonHtml
            // 
            this.buttonHtml.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHtml.FlatAppearance.BorderSize = 0;
            this.buttonHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHtml.Location = new System.Drawing.Point(914, 47);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(152, 51);
            this.buttonHtml.TabIndex = 2;
            this.buttonHtml.Text = "HTML";
            this.buttonHtml.UseVisualStyleBackColor = false;
            // 
            // gridAbout
            // 
            this.gridAbout.AllowUserToAddRows = false;
            this.gridAbout.AllowUserToDeleteRows = false;
            this.gridAbout.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAbout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridAbout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAbout.Location = new System.Drawing.Point(3, 104);
            this.gridAbout.MultiSelect = false;
            this.gridAbout.Name = "gridAbout";
            this.gridAbout.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAbout.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAbout.RowHeadersVisible = false;
            this.gridAbout.RowHeadersWidth = 51;
            this.gridAbout.RowTemplate.Height = 24;
            this.gridAbout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAbout.Size = new System.Drawing.Size(1063, 615);
            this.gridAbout.TabIndex = 3;
            // 
            // buttonEditContent
            // 
            this.buttonEditContent.BackColor = System.Drawing.Color.Orange;
            this.buttonEditContent.FlatAppearance.BorderSize = 0;
            this.buttonEditContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditContent.Location = new System.Drawing.Point(420, 47);
            this.buttonEditContent.Name = "buttonEditContent";
            this.buttonEditContent.Size = new System.Drawing.Size(152, 51);
            this.buttonEditContent.TabIndex = 2;
            this.buttonEditContent.Text = "Edit content";
            this.buttonEditContent.UseVisualStyleBackColor = false;
            this.buttonEditContent.Visible = false;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridAbout);
            this.Controls.Add(this.buttonHtml);
            this.Controls.Add(this.buttonEditContent);
            this.Controls.Add(this.buttonAddabout);
            this.Controls.Add(this.label1);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(1078, 722);
            ((System.ComponentModel.ISupportInitialize)(this.gridAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddabout;
        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.DataGridView gridAbout;
        private System.Windows.Forms.Button buttonEditContent;
    }
}
