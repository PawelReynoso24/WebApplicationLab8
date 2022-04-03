using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationLab8
{
    public partial class _Default : Page
    {
        List<Alumno> alumnos = new List<Alumno>();

        private void LeerAlumnos()
        {
            string fileName = Server.MapPath("~/Alumnos");


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            
            {
                //richTextBox1.AppendText(reader.ReadLine());
            }
            
            reader.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}