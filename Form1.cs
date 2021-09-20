using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorHTML.ContenierControl;

namespace GeneratorHTML
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            buttonAboutyou.Click += ButtonAboutyou_Click;
            buttonhobbies.Click += Buttonhobbies_Click;
            buttonseries.Click += Buttonseries_Click;
            buttonyoutube.Click += Buttonyoutube_Click;
            buttoncontacts.Click += Buttoncontacts_Click;

        }

        private void Buttoncontacts_Click(object sender, EventArgs e)
        {
            ShowUserControl(new contacts());
        }

        private void Buttonyoutube_Click(object sender, EventArgs e)
        {
            ShowUserControl(new YoutubeControl());
        }

        private void Buttonseries_Click(object sender, EventArgs e)
        {
            ShowUserControl(new seriesControl());
        }

        private void Buttonhobbies_Click(object sender, EventArgs e)
        {
            ShowUserControl(new HobbiesControl());
        }

        private void ButtonAboutyou_Click(object sender, EventArgs e)
        {
         
            ShowUserControl(new AboutControl());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }

        /// <summary>
        /// Metodo para agregar el UserControl al panel
        /// </summary>
        /// <param name="control">Recibe un controlador como parametro</param>
        public void ShowUserControl(Control control)
        {
            bodycontenier.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

           bodycontenier.Controls.Add(control);



        }
    }
}
