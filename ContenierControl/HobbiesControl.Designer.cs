
namespace GeneratorHTML.ContenierControl
{
    partial class HobbiesControl
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
            this.GeneratorHTML = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addHobbies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridHobbies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridHobbies)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratorHTML
            // 
            this.GeneratorHTML.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GeneratorHTML.FlatAppearance.BorderSize = 0;
            this.GeneratorHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratorHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratorHTML.Location = new System.Drawing.Point(914, 40);
            this.GeneratorHTML.Name = "GeneratorHTML";
            this.GeneratorHTML.Size = new System.Drawing.Size(152, 51);
            this.GeneratorHTML.TabIndex = 5;
            this.GeneratorHTML.Text = "HTML";
            this.GeneratorHTML.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit content";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // addHobbies
            // 
            this.addHobbies.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addHobbies.FlatAppearance.BorderSize = 0;
            this.addHobbies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHobbies.Location = new System.Drawing.Point(736, 40);
            this.addHobbies.Name = "addHobbies";
            this.addHobbies.Size = new System.Drawing.Size(152, 51);
            this.addHobbies.TabIndex = 7;
            this.addHobbies.Text = "Add content";
            this.addHobbies.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hobbies";
            // 
            // gridHobbies
            // 
            this.gridHobbies.AllowUserToAddRows = false;
            this.gridHobbies.AllowUserToDeleteRows = false;
            this.gridHobbies.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.gridHobbies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHobbies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridHobbies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHobbies.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridHobbies.Location = new System.Drawing.Point(3, 97);
            this.gridHobbies.MultiSelect = false;
            this.gridHobbies.Name = "gridHobbies";
            this.gridHobbies.ReadOnly = true;
            this.gridHobbies.RowHeadersVisible = false;
            this.gridHobbies.RowHeadersWidth = 51;
            this.gridHobbies.RowTemplate.Height = 24;
            this.gridHobbies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHobbies.Size = new System.Drawing.Size(1072, 615);
            this.gridHobbies.TabIndex = 3;
            // 
            // HobbiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GeneratorHTML);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addHobbies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridHobbies);
            this.Name = "HobbiesControl";
            this.Size = new System.Drawing.Size(1078, 722);
            ((System.ComponentModel.ISupportInitialize)(this.gridHobbies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneratorHTML;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addHobbies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridHobbies;
    }
}
