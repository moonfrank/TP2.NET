using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        public SqlDataAdapter DaPersonas { get; set; }
        public Personas()
        {
            this.DaPersonas = new SqlDataAdapter("SELECT * FROM personas", this.Conn);

            this.DaPersonas.UpdateCommand = new SqlCommand("UPDATE personas" +
                "SET nombre=@nombre, apellido=@apellido, direccion=@direccion, telefono=@telefono, fecha_nac=@fecha_nac," +
                "legajo=@legajo, tipo_persona=@tipo_persona, id_plan=@id_plan WHERE id_persona=@id_persona", this.Conn);
            this.DaPersonas.UpdateCommand.Parameters.Add("@id_persona", SqlDbType.Int, 1, "id_persona");
            this.DaPersonas.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaPersonas.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaPersonas.UpdateCommand.Parameters.Add("direccion", SqlDbType.VarChar, 50, "direccion");
            this.DaPersonas.UpdateCommand.Parameters.Add("telefono", SqlDbType.VarChar, 50, "telefono");
            this.DaPersonas.UpdateCommand.Parameters.Add("fecha_nac", SqlDbType.DateTime, 50, "fecha_nac");
            this.DaPersonas.UpdateCommand.Parameters.Add("tipo_persona", SqlDbType.Int, 1, "tipo_persona");
            this.DaPersonas.UpdateCommand.Parameters.Add("id_plan", SqlDbType.Int, 1, "id_plan");

            this.DaPersonas.InsertCommand = new SqlCommand("INSERT INTO personas(nombre, apellido, " +
                "direccion, telefono, fecha_nac, legajo, tipo_persona) VALUES (@nombre, @apellido, @direccion, @telefono," +
                "@fecha_nac, @legajo, @tipo_persona, @id_plan)", this.Conn);
            this.DaPersonas.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.DaPersonas.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.DaPersonas.InsertCommand.Parameters.Add("direccion", SqlDbType.VarChar, 50, "direccion");
            this.DaPersonas.InsertCommand.Parameters.Add("telefono", SqlDbType.VarChar, 50, "telefono");
            this.DaPersonas.InsertCommand.Parameters.Add("fecha_nac", SqlDbType.DateTime, 50, "fecha_nac");
            this.DaPersonas.InsertCommand.Parameters.Add("tipo_persona", SqlDbType.Int, 1, "tipo_persona");
            this.DaPersonas.InsertCommand.Parameters.Add("id_plan", SqlDbType.Int, 1, "id_plan");

            this.DaPersonas.DeleteCommand = new SqlCommand("DELETE FROM personas WHERE id_persona=@id_persona", this.Conn);
            this.DaPersonas.DeleteCommand.Parameters.Add("@id_persona", SqlDbType.Int, 1, "id_persona");
        }

        public DataTable GetAll()
        {
            DataTable dtPersonas = new DataTable();
            this.DaPersonas.Fill(dtPersonas);
            return dtPersonas;
        }
        public void GuardarCambios(DataTable dtPersonas)
        {
            this.DaPersonas.Update(dtPersonas);
            dtPersonas.AcceptChanges();
        }
    }
}
