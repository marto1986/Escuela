using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEscuela;

namespace BTL_Escuela
{
    public class EscuelaOperaciones:IDisposable
    {
        // Recursos manejados
        private Component componentes = new Component();
        DALEscuela.EscuelaDataContext dalContext;

        // Indica si ya se llamó al método Dispose (default = false)
        private bool disposed;

        /// <summary>
        /// Implementación de Dispose. No se sobreescribe.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);

            // GC.SuppressFinalize quita de la cola de finalización al objeto.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    // Llmamos al Dispose de todos los RECURSOS MANEJADOS.

                    this.componentes.Dispose();
                    this.componentes = null;
                }

                // Acá finalizamos correctamente los RECURSOS NO MANEJADOS
            }

            this.disposed = true;
        }

        /// <summary>
        /// Destructor de la instancia
        /// </summary>
       ~EscuelaOperaciones()
        {
            this.Dispose(false);
        }

        public EscuelaOperaciones(string conexion)
        {
            dalContext = new DALEscuela.EscuelaDataContext(conexion);
        }

        #region SELECT
        public DataTable TraerAlumnos()
        {
            DataTable dt = new DataTable();

            try
            {
                using (EscuelaDataContext db = new EscuelaDataContext())
                {
                    return dt = CustomDataTable.CopyToDataTable(db.SPSalumnos().ToArray());
                }
            }
            catch(Exception)
            {
                dt = null;
                return dt;
            }
        }
        #endregion

        #region INSERT
        public bool GuardarAlumno(string nombre, string apPaterno, string apMaterno, string email)
        {
            try
            {

                using (EscuelaDataContext db = new EscuelaDataContext())
                {
                    db.SPIalumnos(nombre, apPaterno, apMaterno, email);
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
        #endregion

        #region UPDATE
        public bool ActualizarAlumno(int alumnoId, string nombre, string apPaterno, string apMaterno, string email)
        {
            try
            {

                using (EscuelaDataContext db = new EscuelaDataContext())
                {
                    db.SPAalumnos(alumnoId, nombre, apPaterno, apMaterno, email);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region
        public bool EliminarAlumno(int alumnoId)
        {
            try
            {

                using (EscuelaDataContext db = new EscuelaDataContext())
                {
                    db.SPEalumnos(alumnoId);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
