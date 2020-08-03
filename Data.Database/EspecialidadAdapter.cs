using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidad = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades", sqlConnection);
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                    especialidad.Add(esp);
                }
                drEspecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidad;
        }
        public Especialidad GetOne(int ID)
        {
            return new Especialidad();
        }

        public void Delete(int ID)
        {

        }

        protected void Update(Especialidad especialidad)
        {
           
        }

        protected void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades(desc_especialidad)" +
                " VALUES (@desc_especialidad) select @@identity", sqlConnection);
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 100).Value = especialidad.Descripcion;
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear Especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
