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
    public partial class HobbiesControl : UserControl
    {
        public string fullPath;
        public HobbiesControl()
        {
            InitializeComponent();
            loadData();
            addHobbies.Click += AddHobbies_Click;
            GeneratorHTML.Click += GeneratorHTML_Click;
            imagenDefaul();
        }

        private void GeneratorHTML_Click(object sender, EventArgs e)
        {
            GeneratorHtml();
        }

        private void AddHobbies_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var hoobies = new formHobbies();
                hoobies.pageTittle.Text = "Add content";
              


                hoobies.ShowDialog();

            }
       
            loadData();
        }
        /// <summary>
        /// obtener la img de portada
        /// </summary>
        public void imagenDefaul()
        {
            string fileName = "img2.jpg";
            fullPath = Path.GetFullPath(fileName);
        }
        /// <summary>
        /// para cargar el contenido en el datagridview
        /// </summary>
        public void loadData()
        {
            using (PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
            {

                var data = from hobbies in db.pasatiempos
                           select hobbies;


                gridHobbies.DataSource = data.ToList();
                //Para cambiar el nombre a las columnas


                gridHobbies.Columns[0].HeaderText = "HobbiesId";
                gridHobbies.Columns[1].HeaderText = "Name";
                gridHobbies.Columns[2].HeaderText = "Hobbies";

            }
        }

        /// <summary>
        /// para obtener los id del contenido
        /// </summary>
        /// <returns></returns>
        public int? getId()
        {
            try
            {

                return (int)gridHobbies.Rows[gridHobbies.CurrentRow.Index].Cells[0].Value;
            }
            catch (Exception)
            {

                return null;
            }


        }
        public void GeneratorHtml()
        {
            using (StreamWriter sw = new StreamWriter("Index.html"))
            {
                try
                {
                    //variables para obtener los datos aqui empieza
                   
                    string Name = (string)gridHobbies.Rows[gridHobbies.CurrentRow.Index].Cells[1].Value;
                    string Hobbies = (string)gridHobbies.Rows[gridHobbies.CurrentRow.Index].Cells[2].Value;
                    //aqui termina


                    sw.WriteLine("<!DOCTYPE html>");

                    sw.WriteLine("<html lang='en'>");

                    sw.WriteLine("<head>");
                    sw.WriteLine("<link href = 'https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel = 'stylesheet' integrity = 'sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin = 'anonymous'>");
                    sw.WriteLine("<title>Hobbies</title>");
                    sw.WriteLine("</head>");

                   

                    sw.WriteLine("<div class='container'>");
                    sw.WriteLine($"<header style={"padding-top:10px;"}>");
                    sw.WriteLine("<h1>Hobbies</h1>");
                    sw.WriteLine("</header>");
                    sw.WriteLine($"<img style ={"padding-top: 10px;"} src='{fullPath}' alt='Hobbies' height='200' width='150'>");
                    sw.WriteLine($"<p> <b>name:</b> {Name}</p>");
                    sw.WriteLine($"<p style='margin-top:-8px;'>{Hobbies}</p>");
                    sw.WriteLine("</div>");

                    sw.WriteLine("<body>");
                   

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
