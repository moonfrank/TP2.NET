using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Comisiones : BusinessEntity
    {
        public SqlDataAdapter DaComisiones { get; set; }
        public Comisiones():base()
        {
            this.DaComisiones = new SqlDataAdapter("select * from comisiones", this.Conn);

            this.DaComisiones.UpdateCommand =
            new SqlCommand(" UPDATE comisiones " +
            " SET desc_comision = @desc_comision, id_plan = @id_plan, anio_especialidad=@anio_especialidad WHERE id_comision=@id_comision ", this.Conn);
            this.DaComisiones.UpdateCommand.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50, "desc_comision");
            this.DaComisiones.UpdateCommand.Parameters.Add("@id_comision", SqlDbType.Int, 1, "id_comision");
            this.DaComisiones.UpdateCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
            this.DaComisiones.UpdateCommand.Parameters.Add("@anio_especialidad", SqlDbType.Int, 1, "anio_especialidad");

            this.DaComisiones.InsertCommand =
            new SqlCommand("INSERT INTO comisiones (desc_comision,anio_especialidad,id_plan) VALUES (@desc_comision,@anio_especialidad,@id_plan)", this.Conn);
            this.DaComisiones.InsertCommand.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50, "desc_comision");
            this.DaComisiones.InsertCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
            this.DaComisiones.InsertCommand.Parameters.Add("@anio_especialidad", SqlDbType.Int, 1, "anio_especialidad");

            this.DaComisiones.DeleteCommand = new SqlCommand(" DELETE FROM comisiones WHERE id_comision=@id_comision ", this.Conn);
            this.DaComisiones.DeleteCommand.Parameters.Add("@id_comision", SqlDbType.Int, 1, "id_comision");
        }

        public DataTable GetAll()
        {
            DataTable dtComisiones = new DataTable();
            this.DaComisiones.Fill(dtComisiones);
            return dtComisiones;
        }

        public void GuardarCambios(DataTable dtComisiones)
        {
            this.DaComisiones.Update(dtComisiones);
            dtComisiones.AcceptChanges();
        }
    }
}