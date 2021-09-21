using GeneratorHTML.model;
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

namespace GeneratorHTML.ContenierControl
{
    public partial class seriesControl : UserControl
    {
        public seriesControl()
        {
          
            InitializeComponent();
            loadData();
            addSeries.Click += AddSeries_Click;
            buttonHtml.Click += ButtonHtml_Click;
        }

        private void ButtonHtml_Click(object sender, EventArgs e)
        {
            GeneratorHtml();
        }

        private void AddSeries_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var serie = new formSerie();
                serie.pageTittle.Text = "Add content";



                serie.ShowDialog();

            }

            loadData();
        }

        /// <summary>
        /// General el codigo html 
        /// </summary>
        public void GeneratorHtml()
        {
            using (StreamWriter sw = new StreamWriter("Index.html"))
            {
                try
                {
                    //variables para obtener los datos aqui empieza

                    string serie = (string)gridSeries.Rows[gridSeries.CurrentRow.Index].Cells[1].Value;
                    string trailer = (string)gridSeries.Rows[gridSeries.CurrentRow.Index].Cells[2].Value;
                    //aqui termina


                    sw.WriteLine("<!DOCTYPE html>");

                    sw.WriteLine("<html lang='en'>");

                    sw.WriteLine("<head>");
                    sw.WriteLine("<link href = 'https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel = 'stylesheet' integrity = 'sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin = 'anonymous'>");
                    sw.WriteLine("<title>Series favorites</title>");
                    sw.WriteLine("</head>");

                    sw.WriteLine("<body>");

                    sw.WriteLine($"<div class='container'style={"padding-top:20px;"}>");

                    sw.WriteLine($"<header style={"padding-bottom: 15px;"}>");
                    sw.WriteLine("<h1>Series Favorites</h1>");
                    sw.WriteLine("</header>");

                    sw.WriteLine("<article>");
                    sw.WriteLine($"<h5>{serie}</h5>");
                    sw.WriteLine("<video width='720' controls>");
                    sw.WriteLine($"<source src='{trailer}' type='video/mp4'>");
                    sw.WriteLine("</video>");
                    sw.WriteLine("</article>");

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

        /// <summary>
        /// para cargar el contenido en el datagridview
        /// </summary>
        public void loadData()
        {
            using (PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
            {

                var data = from serie in db.SeriesFavs
                           select serie;


                gridSeries.DataSource = data.ToList();

                //Para cambiar el nombre a las columnas
                gridSeries.Columns[0].HeaderText = "SerieId";
                gridSeries.Columns[1].HeaderText = "Serie";
                gridSeries.Columns[2].HeaderText = "Trailer";

            }
        }
       
    }

}
