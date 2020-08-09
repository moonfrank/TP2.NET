using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Materias:BusinessEntity
    {
        public SqlDataAdapter DaMaterias { get; set; }
        public Materias() : base()
        {
            this.DaMaterias = new SqlDataAdapter("select * from materias", this.Conn);

            this.DaMaterias.UpdateCommand = new SqlCommand(" UPDATE materias SET" +
            " desc_materia = @desc_materia, hs_semanales = @hs_semanales, hs_totales = @hs_totales" +
            " id_plan = @id_plan WHERE id_materia=@id_materia", this.Conn);
            this.DaMaterias.UpdateCommand.Parameters.Add("@id_materia", SqlDbType.Int, 1, "id_materia");
            this.DaMaterias.UpdateCommand.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50, "desc_materia");
            this.DaMaterias.UpdateCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
            this.DaMaterias.UpdateCommand.Parameters.Add("@hs_semanales", SqlDbType.Int, 1, "hs_semanales");
            this.DaMaterias.UpdateCommand.Parameters.Add("@hs_totales", SqlDbType.Int, 1, "hs_totales");

            this.DaMaterias.InsertCommand = new SqlCommand(" INSERT INTO materias(id_materia,id_plan,desc_materia,hs_semanales,hs_totales) " +
                " VALUES (@id_materia,@id_plan,@desc_materia,@hs_semanales,@hs_totales)", this.Conn);
            this.DaMaterias.InsertCommand.Parameters.Add("@id_materia", SqlDbType.Int, 1, "id_materia");
            this.DaMaterias.InsertCommand.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50, "desc_materia");
            this.DaMaterias.InsertCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
            this.DaMaterias.InsertCommand.Parameters.Add("@hs_semanales", SqlDbType.Int, 1, "hs_semanales");
            this.DaMaterias.InsertCommand.Parameters.Add("@hs_totales", SqlDbType.Int, 1, "hs_totales");

            this.DaMaterias.DeleteCommand = new SqlCommand(" DELETE FROM materias WHERE id_materia=@id_materia", this.Conn);
            this.DaMaterias.DeleteCommand.Parameters.Add("@id_materia", SqlDbType.Int, 1, "id_materia");
        }

        public DataTable GetAll()
        {
            DataTable dtMaterias = new DataTable();
            this.DaMaterias.Fill(dtMaterias);
            return dtMaterias;
        }

        public void GuardarCambios(DataTable dtMaterias)
        {
            this.DaMaterias.Update(dtMaterias);
            dtMaterias.AcceptChanges();
        }
    }
}
