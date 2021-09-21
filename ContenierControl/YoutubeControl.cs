using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorHTML.model;

namespace GeneratorHTML.ContenierControl
{
    public partial class YoutubeControl : UserControl
    {
        public string fullPath;
        public YoutubeControl()
        {
            InitializeComponent();
            loadData();
            imagenDefaul();
            addYoutube.Click += AddYoutube_Click;
            buttonHtml.Click += ButtonHtml_Click;
        }

        private void ButtonHtml_Click(object sender, EventArgs e)
        {
            GeneratorHtml();
        }

        private void AddYoutube_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var youtube = new formYoutube();
                youtube.pageTittle.Text = "Add content";



                youtube.ShowDialog();

            }

            loadData();

        }

        /// <summary>
        /// para cargar el contenido en el datagridview
        /// </summary>
        public void loadData()
        {
            using (PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
            {

                var data = from youtube in db.youtuberFavs
                           select youtube;


                gridYoutube.DataSource = data.ToList();
                //Para cambiar el nombre a las columnas


                gridYoutube.Columns[0].HeaderText = "YoutubeId";
                gridYoutube.Columns[1].HeaderText = "Youtube Favorites";
                gridYoutube.Columns[2].HeaderText = "Link channel";

            }
        }
        /// <summary>
        /// obtener la img de portada
        /// </summary>
        public void imagenDefaul()
        {
            string fileName = "img3.jpg";
            fullPath = Path.GetFullPath(fileName);
        }
        public void GeneratorHtml()
        {
            using (StreamWriter sw = new StreamWriter("Index.html"))
            {
                try
                {
                    //variables para obtener los datos aqui empieza

                    string youtube = (string)gridYoutube.Rows[gridYoutube.CurrentRow.Index].Cells[1].Value;
                    string linkChannel = (string)gridYoutube.Rows[gridYoutube.CurrentRow.Index].Cells[2].Value;
                    //aqui termina


                    sw.WriteLine("<!DOCTYPE html>");

                    sw.WriteLine("<html lang='en'>");

                    sw.WriteLine("<head>");
                    sw.WriteLine("<link href = 'https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel = 'stylesheet' integrity = 'sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin = 'anonymous'>");
                    sw.WriteLine("<title>Youtube favorites</title>");
                    sw.WriteLine("</head>");

                    sw.WriteLine("<body>");

                    sw.WriteLine($"<div class='container'style={"padding-top:25px;"}>");

                    sw.WriteLine($"<header style={"padding-bottom: 15px;"}>");
                    sw.WriteLine("<h1>Youtube favorites</h1>");
                    sw.WriteLine("</header>");

                    sw.WriteLine($"<div class='card' style='width:16rem;'>");
                    sw.WriteLine($"<img src='{fullPath}' class='card-img-top' alt='Youtube'>");

                    sw.WriteLine($"<div class={"card-body"} >");
                    sw.WriteLine($"<h4 class={"card-title"}>{youtube}</h4>");
                    sw.WriteLine($"<a href={linkChannel} target='_blank' class='btn btn-primary'>{"visit channel"}</a>");

                    sw.WriteLine("</div>");
                    sw.WriteLine("</div>");
                    sw.WriteLine("</div>");
                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");
                    sw.Close();
                    
                    var result = MessageBox.Show($"Page created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = "Index.html";
                        p.Start();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





            }

        }
    }
}
