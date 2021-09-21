using GeneratorHTML.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorHTML
{
    public partial class formContact : Form
    {
        public formContact()
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
                    formularioContacto c = new formularioContacto();
                    c.Nombre = txtName.Text.ToString();
                    c.apellido = txtLastName.Text.ToString();
                    c.Email = txtEmail.Text.ToString();
                    c.telefono = txtPhone.Text.ToString();
                    c.facebook = txtFacebook.Text.ToString();
                    c.instagram = txtInstagram.Text.ToString();
                    c.whatsApp = txtWhatsApp.Text.ToString();

                    db.formularioContactos.Add(c);
                    db.SaveChanges();
                    var result = MessageBox.Show($"Saved successfully! Contact form: {c.formularioId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtWhatsApp.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
