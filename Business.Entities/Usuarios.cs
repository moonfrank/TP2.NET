using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Usuarios
    {
        public SqlDataAdapter DaUsuarios { get; set; }
        public SqlConnection Conn { get; set; }
        public Usuarios()
        {
            //this.Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True");

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

            this.DaUsuarios = new SqlDataAdapter("select * from usuarios", this.Conn);

            this.DaUsuarios.UpdateCommand =
            new SqlCommand(" UPDATE usuarios " +
            " SET id_usuario = @id_usuario, nombre_usuario = @nombre_usuario, clave = @clave" +
            " apellido = @apellido, nombre = @nombre, habilitado = @habilitado, email = @email" +
            "  WHERE id_usuario=@id_usuario ", this.Conn);
            this.DaUsuarios.UpdateCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 1, "id_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 50, "habilitado");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");


            this.DaUsuarios.InsertCommand =
            new SqlCommand(" INSERT INTO usuarios(id_usuari,nombre_usuario,clave,apellido, " +
                " nombre,habilitado,email) " +
                " VALUES (@id_usuario,@nombre_usuario,@clave,@apellido,@nombre,@habilitado, @email)", this.Conn);
            this.DaUsuarios.UpdateCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 1, "id_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 50, "habilitado");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");

            this.DaUsuarios.DeleteCommand =
                         new SqlCommand(" DELETE FROM usuarios WHERE id_usuario=@id_usuario ", this.Conn);
            this.DaUsuarios.DeleteCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 1, "id_usuario");
        }

        public DataTable GetAll()
        {
            DataTable dtUsuarios = new DataTable();
            this.DaUsuarios.Fill(dtUsuarios);
            return dtUsuarios;
        }

        public void GuardarCambios(DataTable dtUsuarios)
        {
            this.DaUsuarios.Update(dtUsuarios);
            dtUsuarios.AcceptChanges();
        }
    }
}
