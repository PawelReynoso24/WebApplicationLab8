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
       static List<Inscripciones> inscripciones = new List<Inscripciones>();

        private void LeerAlumnos()
        {
            string fileName = Server.MapPath("~/Archivos/Estudiantes.txt");


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
            string fileName = Server.MapPath("~/Archivos/Inscripciones.txt");

            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(stream);

            foreach (var inscripcion in inscripciones)
            {
                writer.WriteLine(inscripcion.carne);
                writer.WriteLine(inscripcion.grado);
                writer.WriteLine(inscripcion.fecha);
            }

            writer.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //PostBack: cuando se carga la primera vez no es postback
            //todas las demás veces que se vuelve a cargar si es postback

            //El if controla que cargue los datos, solo la primera vez que
            //no es postback, las demás se las salta.
            if (!IsPostBack)
            {
                LeerAlumnos();

                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "carne";
                DropDownList1.DataSource = alumnos;
                DropDownList1.DataBind();
            }
        }
        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.carne = DropDownList1.SelectedValue;
            inscripcion.grado = Convert.ToInt16(TextBoxGrado.Text);
            inscripcion.fecha = DateTime.Now;

            inscripciones.Add(inscripcion);

            GuardarInscripciones();
        }
    }
}