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
    public partial class formSerie : Form
    {
        string rutaVideo;
        public formSerie()
        {
            InitializeComponent();
            buttonAddVideo.Click += ButtonAddVideo_Click;
            buttonSave.Click += ButtonSave_Click;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
                {
                   SeriesFav s = new SeriesFav();
                    s.SerieFav = textBox1.Text.ToString();
                    s.trailer = rutaVideo;

                    db.SeriesFavs.Add(s);
                    db.SaveChanges();
                    var result = MessageBox.Show($"Saved successfully! serie: {s.serieId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            player.close();
        }

        private void ButtonAddVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
                rutaVideo = openFile.FileName;
                player.URL = rutaVideo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            player.close();
        }
    }
}
