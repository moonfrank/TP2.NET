using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Usuarios:BusinessEntity
    {
        public SqlDataAdapter DaUsuarios { get; set; }
        public Usuarios():base()
        {
            this.DaUsuarios = new SqlDataAdapter("select * from usuarios", this.Conn);

            this.DaUsuarios.UpdateCommand = new SqlCommand(" UPDATE usuarios " +
            " id_usuario = @id_usuario, nombre_usuario = @nombre_usuario, clave = @clave" +
            " apellido = @apellido, nombre = @nombre, habilitado = @habilitado, email = @email" +
            "  WHERE id_usuario=@id_usuario ", this.Conn);
            this.DaUsuarios.UpdateCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 1, "id_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 50, "habilitado");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");

            this.DaUsuarios.InsertCommand =new SqlCommand(" INSERT INTO usuarios(id_usuario,nombre_usuario,clave,habilitado, " +
                " nombre,apellido,email) " +
                " VALUES (@id_usuario,@nombre_usuario,@clave,@habilitado,@nombre,@apellido, @email)", this.Conn);
            this.DaUsuarios.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 1, "id_usuario");
            this.DaUsuarios.InsertCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario");
            this.DaUsuarios.InsertCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            this.DaUsuarios.InsertCommand.Parameters.Add("@habilitado", SqlDbType.Bit, 50, "habilitado");
            this.DaUsuarios.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaUsuarios.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaUsuarios.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");

            this.DaUsuarios.DeleteCommand = new SqlCommand(" DELETE FROM usuarios WHERE id_usuario=@id_usuario ", this.Conn);
            this.DaUsuarios.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
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
