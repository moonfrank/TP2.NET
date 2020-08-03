using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Entities
{
    public class Planes:BusinessEntity
    {
        public SqlDataAdapter DaPlanes { get; set; }
        public SqlConnection Conn { get; set; }
        public Planes()
        {
            this.Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=True");

            //this.Conn = new SqlConnection("Data Source=localhost;Initial Catalog=tp2_net;Integrated Security=True");

            this.DaPlanes = new SqlDataAdapter("select * from planes", this.Conn);

            this.DaPlanes.UpdateCommand =
            new SqlCommand(" UPDATE planes " +
            " SET desc_plan = @desc_plan, id_especialidad = @id_especialidad WHERE id_plan=@id_plan ", this.Conn);
            this.DaPlanes.UpdateCommand.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50, "desc_plan");
            this.DaPlanes.UpdateCommand.Parameters.Add("@id_especialidad", SqlDbType.Int, 1, "id_especialidad");
            this.DaPlanes.UpdateCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
            this.DaPlanes.InsertCommand =
            new SqlCommand("INSERT INTO planes (desc_plan,id_especialidad) VALUES (@desc_plan,@id_especialidad)", this.Conn);
            this.DaPlanes.InsertCommand.Parameters.Add("@id_especialidad", SqlDbType.Int, 1, "id_especialidad");
            this.DaPlanes.InsertCommand.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50, "desc_plan");

            this.DaPlanes.DeleteCommand =
                         new SqlCommand(" DELETE FROM planes WHERE id_plan=@id_plan ", this.Conn);
            this.DaPlanes.DeleteCommand.Parameters.Add("@id_plan", SqlDbType.Int, 1, "id_plan");
        }

        public DataTable GetAll()
        {
            DataTable dtPlanes = new DataTable();
            this.DaPlanes.Fill(dtPlanes);
            return dtPlanes;
        }

        public void GuardarCambios(DataTable dtPlanes)
        {
            this.DaPlanes.Update(dtPlanes);
            dtPlanes.AcceptChanges();
        }
    }
}
