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
        List<Inscripciones> inscripciones = new List<Inscripciones>();

        private void LeerAlumnos()
        {
            string fileName = Server.MapPath("~/Alumnos");


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            
            {
                Alumno alumno = new Alumno();
                alumno.carne = reader.ReadLine();
                alumno.nombre = reader.ReadLine();

                alumnos.Add(alumno);
            }
            
            reader.Close();
        }
        private void GuardarInscripciones()
        {
            string fileName = Server.MapPath("~/");

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(stream);
            
            writer.WriteLine(texto);
            
            writer.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LeerAlumnos();

            DropDownList1.DataValueField = "nombre";
            DropDownList1.DataSource = alumnos;
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.carne = DropDownList1.SelectedValue;
            inscripcion.grado = Convert.ToInt16(TextBox1);
            inscripcion.fecha = DateTime.Now;

            inscripciones.Add(inscripcion);
        }
    }
}