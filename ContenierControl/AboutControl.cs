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
        }



        private void ButtonHtml_Click(object sender, EventArgs e)
        {
            //if (getId()!=null)
            //{
            //    var modalAbout = new FrmAbout(getId());
            //    modalAbout.ShowDialog();

            //}
            //loadData();
            GeneratorHtml();
        }

        private void ButtonAddabout_Click(object sender, EventArgs e)
        {
            if (true)
            {
                var about = new FrmAbout(null);
           
         
                about.ShowDialog();
              
            }
            loadData();
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
      /// metodo para generar el html 
      /// </summary>
        public void GeneratorHtml()
        {
            string name = (string)gridAbout.Rows[gridAbout.CurrentRow.Index].Cells[4].Value;
           
            using (StreamWriter sw =new StreamWriter("Index.html"))
            {
                sw.WriteLine("<!DOCTYPE html>");

                sw.WriteLine("<html lang='en'>");

                sw.WriteLine("<head>");
                sw.WriteLine("<title>About you</title>");
                sw.WriteLine("<link href = 'https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel = 'stylesheet' integrity = 'sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin = 'anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<header>");
                sw.WriteLine("<h2>About You<h2>");
                sw.WriteLine("</header>");

                sw.WriteLine("<div>");
                sw.WriteLine($"<p>Name:{name}</p>");
                sw.WriteLine("</div>");

                sw.WriteLine($"<img src='{name}' width='100' alt=''>");

                sw.WriteLine("</body>");

                sw.WriteLine("</html>");
                sw.Close();

            }

        }

        /// <summary>
        /// para cargar el contenido en el datagridview
        /// </summary>
        public void loadData()
        {
            using ( PraticaHTMLEntities2 db = new PraticaHTMLEntities2())
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
