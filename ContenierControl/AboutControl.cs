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
using System.IO;
using System.Diagnostics;

namespace GeneratorHTML.ContenierControl
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
            loadData();
            buttonAddabout.Click += ButtonAddabout_Click;
            buttonHtml.Click += ButtonHtml_Click;
            buttonEditContent.Click += ButtonEditContent_Click;
        }

        private void ButtonEditContent_Click(object sender, EventArgs e)
        {

            //if (getId()!=null)
            //{
            //    var about = new FrmAbout(getId());
            //    about.pageTittle.Text = "Edit content";
            //    about.ShowDialog();

            //}
            //loadData();
        }

        private void ButtonHtml_Click(object sender, EventArgs e)
        {
            GeneratorHtml();
           

        }

        private void ButtonAddabout_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var about = new FrmAbout(null);
                about.pageTittle.Text = "Add content";


                about.ShowDialog();

            }
            loadData();
        }        

        /// <summary>
        /// metodo para generar el html 
        /// </summary>
        public void GeneratorHtml()
        {
            using (StreamWriter sw = new StreamWriter("Index.html"))
            {
                try
                {
                    //variables para obtener los datos aqui empieza
                    string NombreCompleto = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[1].Value;
                    DateTime fechaNacimiento = (DateTime)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[2].Value; 

                    string NombreCompletoPadre = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[3].Value; 
                    string imgPadre = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[4].Value;

                    string NombreCompletoMadre = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[5].Value;
                    string imgMadre = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[6].Value;

                    string NombrecompletoPadreAbuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[7].Value;
                    string imgPadreAbuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[8].Value;

                    string NombreCompletoPadreAbuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[9].Value;
                    string imgPadreAbuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[10].Value;

                    string NombrecompletoMadreAbuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[11].Value;
                    string imgMadreAbuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[12].Value;

                    string NombreCompletoMadreAbuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[13].Value;
                    string imgMadreAbuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[14].Value;

                    string NombreCompletoAbuelaBisabuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[15].Value;
                    string imgAbuelaBisabuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[16].Value;

                    string NombreCompletoAbuelaBisabuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[17].Value;
                    string imgAbuelaBisabuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[18].Value;

                    string NombreCompletoAbueloBisabuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[19].Value;
                    string imgAbueloBisabuela = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[20].Value;

                    string NombreCompletoAbueloBisabuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[21].Value;
                    string imgAbueloBisabuelo = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[22].Value;
                    //aqui termina


                    sw.WriteLine("<!DOCTYPE html>");
                 
                    sw.WriteLine("<html lang='en'>");

                    sw.WriteLine("<head>");
                    sw.WriteLine("<link href = 'https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel = 'stylesheet' integrity = 'sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin = 'anonymous'>");
                    sw.WriteLine("<title>About you</title>");
                    sw.WriteLine("</head>");

                    sw.WriteLine("<style>");
                        sw.WriteLine("footer {");
                        sw.WriteLine("text-align: center;");
                        sw.WriteLine("padding: 3px;");
                        sw.WriteLine("background-color: DarkSalmon;");
                        sw.WriteLine("color: white;");
                        sw.WriteLine(" }");
                    sw.WriteLine("</style>");

                    sw.WriteLine("<body>");
                    sw.WriteLine("<div class='container'>");
                    sw.WriteLine("<header>");
                    sw.WriteLine(" <h1 style='padding - top: 30px; padding - bottom: 12px;'>About you</h1>");
                    sw.WriteLine("</header>");
                    sw.WriteLine($"<p> <b>Name:</b> {NombreCompleto}</p>");
                    sw.WriteLine($"<p><b>Birth date: </b> {fechaNacimiento}</p>");
                    sw.WriteLine("</div>");


                    sw.WriteLine(" <section class='container'>");
                    sw.WriteLine("<header>");
                    sw.WriteLine(" <h2> my Genealogy</h1>");
                    sw.WriteLine(" </header>");
                    sw.WriteLine("&nbsp;");


                    sw.WriteLine("<div class='row'>");
                    sw.WriteLine("<div class='col'>");
                    sw.WriteLine("<h3 style='text - align: center;'>Father</h3>");
                        sw.WriteLine("<ul>");
                            sw.WriteLine(" <li>");
                                sw.WriteLine($"<p><b>Father </b> {NombreCompletoPadre}</p>");
                    sw.WriteLine($"<img style={"margin-top:-12px;"} src={imgPadre} alt={"Father"} width={200}>");
                            sw.WriteLine(" </li>");

                            sw.WriteLine(" <li>");
                                sw.WriteLine($"<p><b>Grandma</b> {NombrecompletoPadreAbuela}</p>");
                                sw.WriteLine($"<img style ={"margin-top:-12px;"} src ={imgPadreAbuela} alt={"Grandma"} width= {200}>");
                            sw.WriteLine(" </li>");

                            sw.WriteLine(" <li>");
                                sw.WriteLine($"<p><b>Granfather</b> {NombreCompletoPadreAbuelo}</p>");
                                sw.WriteLine($"<img style ='margin-top:-12px;' src ={imgPadreAbuelo} alt = 'Granfather' width ='200'>");
                            sw.WriteLine(" </li>");

                            sw.WriteLine(" <li>");
                                sw.WriteLine($"<p><b>Great-granmother</b> {NombreCompletoAbueloBisabuela}</p>");
                                sw.WriteLine($"<img style ='margin-top:-12px;' src ={imgAbueloBisabuela} alt='Great-granmother' width = '200'>");
                              sw.WriteLine(" </li>");

                            sw.WriteLine(" <li>");
                                sw.WriteLine($"<p><b>Great-granfather</b> {NombreCompletoAbueloBisabuelo}</p>");
                                sw.WriteLine($"<img style ='margin-top:-12px;' src={imgAbueloBisabuelo} alt='Great-granfather' width ='200'>");
                            sw.WriteLine(" </li>");

                        sw.WriteLine("</ul>");

                    sw.WriteLine("</div>");

                    sw.WriteLine("<div class='col'>");
                    sw.WriteLine("<h3 style='text - align: center;'>Mother</h3>");
                    sw.WriteLine("<ul>");
                    sw.WriteLine(" <li>");
                    sw.WriteLine($"<p><b>Mother </b> {NombreCompletoMadre}</p>");
                    sw.WriteLine($"<img style = 'margin-top:-12px;' src ={imgMadre} alt='Mother' width = '200'>");
                    sw.WriteLine(" </li>");

                    sw.WriteLine(" <li>");
                    sw.WriteLine($"<p><b>Grandma</b> {NombrecompletoMadreAbuela}</p>");
                    sw.WriteLine($"<img style = 'margin-top:-12px;' src ={imgMadreAbuela} alt = 'Grandma' width = '200'>");
                    sw.WriteLine("</li>");

                    sw.WriteLine(" <li>");
                    sw.WriteLine($"<p><b>Granfather</b> {NombreCompletoMadreAbuelo}</p>");
                    sw.WriteLine($"<img style = 'margin-top:-12px;' src ='{imgMadreAbuelo}' alt ='Granfather' width = '200'>");
                    sw.WriteLine(" </li>");

                    sw.WriteLine(" <li>");
                    sw.WriteLine($"<p><b>Great-granmother</b> {NombreCompletoAbuelaBisabuela}</p>");
                    sw.WriteLine($"<img style = 'margin-top:-12px;' src ='{imgAbuelaBisabuela}' alt = 'Great-granmother' width = '200'>");
                    sw.WriteLine(" </li>");

                    sw.WriteLine(" <li>");
                    sw.WriteLine($"<p><b>Great-granfather</b> {NombreCompletoAbuelaBisabuelo}</p>");
                    sw.WriteLine($"<img style = 'margin-top:-12px;' src = '{imgAbuelaBisabuelo}' alt = 'Great-granfather' width = '200'>");
                    sw.WriteLine(" </li>");

                    sw.WriteLine("</ul>");

                    sw.WriteLine("</div>");
                    sw.WriteLine("</div>");
                    sw.WriteLine("</section>");

                    sw.WriteLine(" <footer>");
                    sw.WriteLine("<p>Author: Oscar De La Rosa<br>");
                    sw.WriteLine("<a href='mailto: brookvivir@gmail.com'>contact me</a></p>");
                    sw.WriteLine(" </footer>");

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
        /// para obtener los id del contenido
        /// </summary>
        /// <returns></returns>
        public int? getId()
        {
            try
            {
               
                return (int)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[0].Value;
            }
            catch (Exception)
            {

                return null;
            }
        
           
        }
      
        /// <summary>
        /// para cargar el contenido en el datagridview
        /// </summary>
        public void loadData()
        {
            using ( PraticaHTMLEntities3 db = new PraticaHTMLEntities3())
            {

                var data = from about in db.InfPersonals
                           select about;


                gridAbout.DataSource = data.ToList();
                //Para cambiar el nombre a las columnas
                gridAbout.Columns[0].HeaderText = "Inf.Id";
                gridAbout.Columns[1].HeaderText = "Name";
                gridAbout.Columns[2].HeaderText = "birth date";
                gridAbout.Columns[3].HeaderText = "father's name";
                gridAbout.Columns[4].HeaderText = "father photo";

                gridAbout.Columns[5].HeaderText = "mother name";
                gridAbout.Columns[6].HeaderText = "mother photo";

                gridAbout.Columns[7].HeaderText = "Grandma name-Dad";
                gridAbout.Columns[8].HeaderText = "Grandma photo-Dad";

                gridAbout.Columns[9].HeaderText = "Grandfather's name-Dad";
                gridAbout.Columns[10].HeaderText = "Grandfather's photo-Dad";

                gridAbout.Columns[11].HeaderText = "Grandma name-mother";
                gridAbout.Columns[12].HeaderText = "Grandma photo-mother";

                gridAbout.Columns[13].HeaderText = "Grandfather's name-mother";
                gridAbout.Columns[14].HeaderText = "Grandfather's photo-mother";

                gridAbout.Columns[15].HeaderText = "Great-granmother name-Grandma";
                gridAbout.Columns[16].HeaderText = "Great-granmother photo-Grandma";

                gridAbout.Columns[17].HeaderText = "Great-granfather name-Grandma";
                gridAbout.Columns[18].HeaderText = "Great-granfather photo-Grandma";

                gridAbout.Columns[19].HeaderText = "Great-granmother name-Grandfather";
                gridAbout.Columns[20].HeaderText = "Great-granmother photo-Grandfather";

                gridAbout.Columns[21].HeaderText = "Great-granfather name-Grandfather";
                gridAbout.Columns[22].HeaderText = "Great-granfather photo-Grandfather";



            }
        }

    
    }
    
}
