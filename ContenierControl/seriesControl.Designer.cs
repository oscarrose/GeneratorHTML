
namespace GeneratorHTML.ContenierControl
{
    partial class seriesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addSeries = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSeries = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHtml
            // 
            this.buttonHtml.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHtml.FlatAppearance.BorderSize = 0;
            this.buttonHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHtml.Location = new System.Drawing.Point(914, 40);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(152, 51);
            this.buttonHtml.TabIndex = 5;
            this.buttonHtml.Text = "HTML";
            this.buttonHtml.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(399, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit content";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // addSeries
            // 
            this.addSeries.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addSeries.FlatAppearance.BorderSize = 0;
            this.addSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSeries.Location = new System.Drawing.Point(732, 40);
            this.addSeries.Name = "addSeries";
            this.addSeries.Size = new System.Drawing.Size(152, 51);
            this.addSeries.TabIndex = 7;
            this.addSeries.Text = "Add content";
            this.addSeries.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Favorites series";
            // 
            // gridSeries
            // 
            this.gridSeries.AllowUserToAddRows = false;
            this.gridSeries.AllowUserToDeleteRows = false;
            this.gridSeries.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.gridSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSeries.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSeries.Location = new System.Drawing.Point(5, 104);
            this.gridSeries.MultiSelect = false;
            this.gridSeries.Name = "gridSeries";
            this.gridSeries.ReadOnly = true;
            this.gridSeries.RowHeadersVisible = false;
            this.gridSeries.RowHeadersWidth = 51;
            this.gridSeries.RowTemplate.Height = 24;
            this.gridSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSeries.Size = new System.Drawing.Size(1072, 615);
            this.gridSeries.TabIndex = 9;
            // 
            // seriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridSeries);
            this.Controls.Add(this.buttonHtml);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addSeries);
            this.Controls.Add(this.label1);
            this.Name = "seriesControl";
            this.Size = new System.Drawing.Size(1078, 722);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridSeries;
    }
}
