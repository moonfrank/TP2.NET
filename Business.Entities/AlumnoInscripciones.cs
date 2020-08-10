using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    class AlumnoInscripciones: BusinessEntity
    {
        public SqlDataAdapter DaInscripciones { get; set; }
        public AlumnoInscripciones() : base()
        {
            this.DaInscripciones = new SqlDataAdapter("select * from alumnos_inscripciones", this.Conn);

            this.DaInscripciones.UpdateCommand =
            new SqlCommand(" UPDATE alumnos_inscripciones " +
            " SET id_alumno=@id_alumno, id_curso=@id_curso, condicion=@condicion, nota=@nota WHERE id_inscripcion=@id_inscripcion ", this.Conn);
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_inscripcion", SqlDbType.Int, 1, "id_inscripcion");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_alumno", SqlDbType.Int, 1, "id_alumno");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_curso", SqlDbType.Int, 1, "id_curso");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@condicion", SqlDbType.VarChar, 50, "condicion");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@nota", SqlDbType.Int, 1, "nota");

            this.DaInscripciones.InsertCommand =
            new SqlCommand("INSERT INTO alumnos_inscripciones (id_inscripcion,id_alumno,id_curso,condicion,nota) VALUES (@id_inscripcion,@id_alumno,@id_curso,@condicion,@nota)", this.Conn);
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_inscripcion", SqlDbType.Int, 1, "id_inscripcion");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_alumno", SqlDbType.Int, 1, "id_alumno");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@id_curso", SqlDbType.Int, 1, "id_curso");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@condicion", SqlDbType.VarChar, 50, "condicion");
            this.DaInscripciones.UpdateCommand.Parameters.Add("@nota", SqlDbType.Int, 1, "nota");

            this.DaInscripciones.DeleteCommand = new SqlCommand(" DELETE FROM comisiones WHERE id_inscripcion=@id_inscripcion ", this.Conn);
            this.DaInscripciones.DeleteCommand.Parameters.Add("@id_inscripcion", SqlDbType.Int, 1, "id_inscripcion");
        }

        public DataTable GetAll()
        {
            DataTable dtInscripciones = new DataTable();
            this.DaInscripciones.Fill(dtInscripciones);
            return dtInscripciones;
        }

        public void GuardarCambios(DataTable dtInscripciones)
        {
            this.DaInscripciones.Update(dtInscripciones);
            dtInscripciones.AcceptChanges();
        }
    }
}
