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
            //this.Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=academia;Integrated Security=True");

            this.Conn = new SqlConnection("Data Source=localhost;Initial Catalog=tp2_net;Integrated Security=True");

            /*    
             *"Data Source=serverisi;Initial Catalog=academia;Integrated Security=false;user=net;password=net;"
             *
             * Este connection string es para conectarse con la base de datos academia en el servidor
             * del departamento sistemas desde una PC de los laboratorios de sistemas,
             * si realiza este Laboratorio desde su PC puede probar el siguiente connection string
             * 
             * "Data Source=localhost;Initial Catalog=academia;Integrated Security=true;"
             * 
             * Si realiza esta práctica sobre el MS SQL SERVER 2005 Express Edition entonce debe 
             * utilizar el siguiente connection string
             * 
             * "Data Source=localhost\SQLEXPRESS;Initial Catalog=academia;Integrated Security=true;"
             */

            this.DaEspecialidades = new SqlDataAdapter("select * from especialidades", this.Conn);

            this.DaEspecialidades.UpdateCommand =
            new SqlCommand(" UPDATE especialidades " +
            " SET desc_especialidad = @desc_especialidad WHERE id=@id ", this.Conn);
            this.DaEspecialidades.UpdateCommand.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 100, "desc_especialidad");
            this.DaEspecialidades.InsertCommand =
            new SqlCommand(" INSERT INTO especialidades(desc_especialidad)" +
                " VALUES (@desc_especialidad)", this.Conn);
            this.DaEspecialidades.UpdateCommand.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 100, "desc_especialidad");

            this.DaEspecialidades.DeleteCommand =
                         new SqlCommand(" DELETE FROM especialidades WHERE id=@id ", this.Conn);
            this.DaEspecialidades.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
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
