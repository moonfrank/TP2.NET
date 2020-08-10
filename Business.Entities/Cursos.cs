using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Cursos:BusinessEntity
    {
        public SqlDataAdapter DaCursos { get; set; }
        public Cursos() : base()
        {
            this.DaCursos = new SqlDataAdapter("select * from cursos", this.Conn);

            this.DaCursos.UpdateCommand = new SqlCommand(" UPDATE cursos " +
            " id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario" +
            " cupo = @cupo WHERE id_curso=@id_curso ", this.Conn);
            this.DaCursos.UpdateCommand.Parameters.Add("@id_curso", SqlDbType.Int, 1, "id_curso");
            this.DaCursos.UpdateCommand.Parameters.Add("@id_materia", SqlDbType.Int, 1, "id_materia");
            this.DaCursos.UpdateCommand.Parameters.Add("@id_comision", SqlDbType.Int, 1, "id_comision");
            this.DaCursos.UpdateCommand.Parameters.Add("@anio_calendario", SqlDbType.Int, 1, "anio_calendario");
            this.DaCursos.UpdateCommand.Parameters.Add("@cupo", SqlDbType.Int, 1,"cupo");

            this.DaCursos.InsertCommand = new SqlCommand(" INSERT INTO cursos(id_curso,id_materia,id_comision,anio_calendario,cupo) " +
                " VALUES (@id_curso,@id_materia,@id_comision,@anio_calendario,@cupo)", this.Conn);
            this.DaCursos.InsertCommand.Parameters.Add("@id_curso", SqlDbType.Int, 1, "id_curso");
            this.DaCursos.InsertCommand.Parameters.Add("@id_materia", SqlDbType.Int, 1, "id_materia");
            this.DaCursos.InsertCommand.Parameters.Add("@id_comision", SqlDbType.Int, 1, "id_comision");
            this.DaCursos.InsertCommand.Parameters.Add("@anio_calendario", SqlDbType.Int, 1, "anio_calendario");
            this.DaCursos.InsertCommand.Parameters.Add("@cupo", SqlDbType.Int, 1, "cupo");

            this.DaCursos.DeleteCommand = new SqlCommand(" DELETE FROM cursos WHERE id_curso=@id_curso ", this.Conn);
            this.DaCursos.DeleteCommand.Parameters.Add("@id_curso", SqlDbType.Int, 1, "id_curso");
        }

        public DataTable GetAll()
        {
            DataTable dtCursos = new DataTable();
            this.DaCursos.Fill(dtCursos);
            return dtCursos;
        }

        public void GuardarCambios(DataTable dtCursos)
        {
            this.DaCursos.Update(dtCursos);
            dtCursos.AcceptChanges();
        }
    }
}
