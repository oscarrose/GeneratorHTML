using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorHTML.model;

namespace GeneratorHTML
{
    public partial class formYoutube : Form
    {
        public formYoutube()
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
                    youtuberFav y = new youtuberFav();
                    y.youtubeFav = textBox1.Text.ToString();
                    y.enlaceCanal = textBox2.Text.ToString();

                    db.youtuberFavs.Add(y);
                    db.SaveChanges();
                    var result = MessageBox.Show($"Saved successfully! Youtube favorites: {y.youtuberFavsId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void formYoutube_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
