using System;
using System.Collections.Generic;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

using static Business.Entities.DocenteCurso;

namespace Data.Database
{
    public class DocenteCursoAdapter:Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> DocentesCursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("select * from docentes_cursos", sqlConnection);
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();
                while (drDocenteCurso.Read())
                {
                    DocenteCurso DocenteCurso = new DocenteCurso();
                    DocenteCurso.ID = (int)drDocenteCurso["id_dictado"];
                    DocenteCurso.IDCurso = (int)drDocenteCurso["id_curso"];
                    DocenteCurso.IDDocente = (int)drDocenteCurso["id_docente"];
                    DocenteCurso.Cargo = (TiposCargos)drDocenteCurso["cargo"];
                    DocentesCursos.Add(DocenteCurso);
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return DocentesCursos;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso DocenteCurso = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("select * from docentes_cursos where id_dictado = @id", sqlConnection);
                cmdDocenteCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();
                if (drDocenteCurso.Read())
                {
                    DocenteCurso.ID = (int)drDocenteCurso["id_dictado"];
                    DocenteCurso.IDCurso = (int)drDocenteCurso["id_curso"];
                    DocenteCurso.IDDocente = (int)drDocenteCurso["id_docente"];
                    DocenteCurso.Cargo = (TiposCargos)drDocenteCurso["cargo"];
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return DocenteCurso;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(DocenteCurso DocenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET id_dictado = @id_dictado, id_curso = @id_curso, id_docente = @id_docente" +
                                                    " cargo = @cargo WHERE id_dictado=@id_dictado ", sqlConnection);
                cmdSave.Parameters.Add("@id_dictado", SqlDbType.Int).Value = DocenteCurso.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = DocenteCurso.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = DocenteCurso.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = (int)DocenteCurso.Cargo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(DocenteCurso DocenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docentes_cursos(id_curso,id_docente,cargo) " +
                                                    " VALUES (@id_curso,@id_docente,@cargo) select @@identity", sqlConnection);
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = DocenteCurso.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = DocenteCurso.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = (int)DocenteCurso.Cargo;
                DocenteCurso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso DocenteCurso)
        {
            if (DocenteCurso.State == BusinessEntity.States.New)
            {
                this.Insert(DocenteCurso);
            }
            else if (DocenteCurso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(DocenteCurso.ID);
            }
            else if (DocenteCurso.State == BusinessEntity.States.Modified)
            {
                this.Update(DocenteCurso);
            }
            DocenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}
