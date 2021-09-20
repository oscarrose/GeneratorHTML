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
    public partial class FrmAbout : Form
    {
        public int? id;
        protected string photoFatherR;
        protected string MotherPhotoR;
        protected string GrandmaDadR;
        protected string GrandFatherDadR;
        protected string grandmaMonR;
        protected string grandFatherMonR;
        protected string greatGradMontherGrandmaR;
        protected string greatGradFatherGrandmaR;
        protected string greatGrandmontherGrandFatherR;
        protected string greatGrandFatherGrandFatherR;


        public FrmAbout( int? id)
        {
            this.id = id;
            InitializeComponent();
            buttonSave.Click += ButtonSave_Click;
            this.Load += FrmAbout_Load1;
            
           
        }

        private void FrmAbout_Load1(object sender, EventArgs e)
        {
            if (id !=null)
            {
                getData();
            }
        }
        /// <summary>
        /// Para guardar el contenido en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (PraticaHTMLEntities2 db = new PraticaHTMLEntities2())
                {
                    InfPersonal personal = new InfPersonal();
                    personal.NombreCompleto = textBox1.Text.ToString();
                    personal.fechaNacimiento = dateTimePicker1.Value;

                    personal.NombreCompletoPadre = textBox2.Text.ToString();
                    personal.imgPadre = photoFatherR;
                    personal.NombreCompletoMadre = textBox3.Text.ToString();
                    personal.imgMadre = MotherPhotoR;

                    personal.NombrecompletoPadreAbuela = textBox4.Text.ToString();
                    personal.imgPadreAbuela = GrandmaDadR;
                    personal.NombreCompletoPadreAbuelo = textBox5.Text.ToString();
                    personal.imgPadreAbuelo = GrandFatherDadR;

                    personal.NombrecompletoMadreAbuela = textBox6.Text.ToString();
                    personal.imgMadreAbuela = grandmaMonR;
                    personal.NombreCompletoMadreAbuelo = textBox7.Text.ToString();
                    personal.imgMadreAbuelo = grandFatherMonR;

                    personal.NombreCompletoAbuelaBisabuela= textBox8.Text.ToString();
                    personal.imgAbuelaBisabuela= greatGradMontherGrandmaR;
                    personal.NombreCompletoAbuelaBisabuelo= textBox9.Text.ToString();
                    personal.imgAbuelaBisabuelo = greatGradFatherGrandmaR;

                    personal.NombreCompletoAbueloBisabuela = textBox10.Text.ToString();
                    personal.imgAbueloBisabuela = greatGrandmontherGrandFatherR;
                    personal.NombreCompletoAbueloBisabuelo = textBox11.Text.ToString();
                    personal.imgAbueloBisabuelo = greatGrandFatherGrandFatherR;

                    db.InfPersonals.Add(personal);
                    db.SaveChanges();
                    var result = MessageBox.Show($"Saved successfully! Categories: {personal.infPersonalId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// para limpiar los textBox
        /// </summary>
        private void clearinput()
        {
            
        }

        /// <summary>
        /// metodo para buscar img
        /// </summary>
        public string searchPhoto()
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();

                fileDialog.Filter = "JPG|*.jpg";
              

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = fileDialog.FileName;

                    return imagen;
                }
                else
                {
                    return null;
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The selected file is not a valid image type {ex}");
                return null;
            }
        }
        /// <summary>
        /// para converir la imagen en un arreglo de bytes
        /// </summary>
        /// <param name="imagen"></param>
        /// <returns></returns>
        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        /// <summary>
        /// Metodo para obtener los datos de la base de datos
        /// </summary>
        public void getData()
        {
            using (PraticaHTMLEntities2 db = new PraticaHTMLEntities2())
            {

                try
                {
                    InfPersonal p = db.InfPersonals.Find(id);
                    textBox1.Text = p.NombreCompleto.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($" {ex},unexpected error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPFather_Click(object sender, EventArgs e)
        {

            photoFatherR = searchPhoto();

            if (photoFatherR != null)
            {
                photofather.Image = Image.FromFile(photoFatherR);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MotherPhotoR = searchPhoto();

            if (MotherPhotoR !=null)
            {
                motherPhoto.Image = Image.FromFile(MotherPhotoR);
            }
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrandmaDadR = searchPhoto();
            pictureBox2.Image = Image.FromFile(GrandmaDadR);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GrandFatherDadR = searchPhoto();
            pictureBox3.Image = Image.FromFile(GrandFatherDadR);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grandmaMonR = searchPhoto();
            pictureBox4.Image = Image.FromFile(grandmaMonR);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grandFatherMonR = searchPhoto();
            pictureBox5.Image = Image.FromFile(grandFatherMonR);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            greatGradMontherGrandmaR = searchPhoto();
            pictureBox6.Image = Image.FromFile(greatGradMontherGrandmaR);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            greatGradFatherGrandmaR = searchPhoto();
            pictureBox7.Image = Image.FromFile(greatGradFatherGrandmaR);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            greatGrandmontherGrandFatherR = searchPhoto();
            pictureBox8.Image = Image.FromFile(greatGrandmontherGrandFatherR);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            greatGrandFatherGrandFatherR = searchPhoto();
            pictureBox9.Image = Image.FromFile(greatGrandFatherGrandFatherR);
        }

        
    }
}
