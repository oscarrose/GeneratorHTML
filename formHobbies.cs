using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorHTML.model;

namespace GeneratorHTML
{
    public partial class formHobbies : Form
    {
        public formHobbies()
        {
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
                {
                    pasatiempos h  = new pasatiempos();
                    h.nombreCompleto = textBox1.Text.ToString();
                    h.PasatiemposFavoritos = textBox2.Text.ToString();
                  
                    db.pasatiempos.Add(h);
                    db.SaveChanges();
                    var result = MessageBox.Show($"Saved successfully! hobbies: {h.pasatiemposId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {

                        clearinput();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearinput()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formHobbies_Load(object sender, EventArgs e)
        {

        }
    }
}
