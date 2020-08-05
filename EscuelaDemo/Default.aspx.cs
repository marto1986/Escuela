using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BTL_Escuela;
using System.Configuration;

namespace EscuelaDemo
{
    public partial class _Default : Page
    {
        EscuelaOperaciones DB = new EscuelaOperaciones(ConfigurationManager.ConnectionStrings["DALEscuela.Properties.Settings.TestConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarAlumno();
            }
        }

        public void CargarAlumno()
        {
            gvdAlumnos.DataSource = DB.TraerAlumnos();
            gvdAlumnos.DataBind();
        }

        public void GuardarAlumno(string Nombre, string ApPaterno, string ApMaterno, string Email)
        {
            DB.GuardarAlumno(Nombre, ApPaterno, ApMaterno, Email);
        }

        protected void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            GuardarAlumno(txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtEmail.Text);
            CargarAlumno();
            pnlAltaAlumno.Visible = false;
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtEmail.Text = "";
        }

        protected void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            pnlAltaAlumno.Visible = true;
        }

        protected void lkbActualizar_Click(object sender, EventArgs e)
        {
            pnlAltaAlumno.Visible = true;
            btnActualizar.Visible = true;
            btnGuardarAlumno.Visible = false;

            // Obtenemos el alumno a modificar
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;

            lblAlumnoId.Text = row.Cells[0].Text;
            txtNombre.Text = row.Cells[1].Text;
            txtApPaterno.Text = row.Cells[2].Text;
            txtApMaterno.Text = row.Cells[3].Text;
            txtEmail.Text = row.Cells[4].Text;

        }

        public void ActualizarAlumno(int AlumnoId, string Nombre, string ApPaterno, string ApMaterno, string Email)
        {
            DB.ActualizarAlumno(AlumnoId, Nombre, ApPaterno, ApMaterno, Email);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            pnlAltaAlumno.Visible = false;
            ActualizarAlumno(Convert.ToInt32(lblAlumnoId.Text), txtNombre.Text, txtApPaterno.Text, txtApMaterno.Text, txtEmail.Text);
            btnActualizar.Visible = false;
            btnGuardarAlumno.Visible = true;
            CargarAlumno();
        }

        public void EliminarAlumno(int AlumnoId)
        {
            DB.EliminarAlumno(AlumnoId);
        }

        protected void lkbEliminar_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            gvdAlumnos.SelectedIndex = row.RowIndex;
            lblAlumnoId.Text = row.Cells[0].Text;
            EliminarAlumno(Convert.ToInt32(lblAlumnoId.Text));
            CargarAlumno();
        }
    }
}