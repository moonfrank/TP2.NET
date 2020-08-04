using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Especialidades
    {
        public SqlDataAdapter DaEspecialidades { get; set; }
        public SqlConnection Conn { get; set; }
        public Especialidades()
        {
            //this.Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True");

            this.Conn = new SqlConnection("Data Source=localhost;Initial Catalog=tp2_net;Integrated Security=True");

            this.DaEspecialidades = new SqlDataAdapter("select * from especialidades", this.Conn);

            this.DaEspecialidades.UpdateCommand =
            new SqlCommand(" UPDATE especialidades " +
            " SET id_especialidad = @id_especialidad desc_especialidad = @desc_especialidad WHERE id_especialidad=@id_especialidad ", this.Conn);
            this.DaEspecialidades.UpdateCommand.Parameters.Add("@id_especialidad", SqlDbType.Int, 1, "id_especialidad");
            this.DaEspecialidades.UpdateCommand.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 100, "desc_especialidad");
            this.DaEspecialidades.InsertCommand =
            new SqlCommand(" INSERT INTO especialidades(desc_especialidad)" +
                " VALUES (@desc_especialidad)", this.Conn);
            this.DaEspecialidades.UpdateCommand.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 100, "desc_especialidad");

            this.DaEspecialidades.DeleteCommand =
                         new SqlCommand(" DELETE FROM especialidades WHERE id_especialidad=@id_especialidad ", this.Conn);
            this.DaEspecialidades.DeleteCommand.Parameters.Add("@id_especialidad", SqlDbType.Int, 1, "id_especialidad");
        }

        public DataTable GetAll()
        {
            DataTable dtEspecialidades = new DataTable();
            this.DaEspecialidades.Fill(dtEspecialidades);
            return dtEspecialidades;
        }

        public void GuardarCambios(DataTable dtEspecialidades)
        {
            this.DaEspecialidades.Update(dtEspecialidades);
            dtEspecialidades.AcceptChanges();
        }
    }
}
