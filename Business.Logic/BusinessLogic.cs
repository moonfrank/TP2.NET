using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class BusinessLogic
    {

    }

    public class UsuarioLogic:BusinessLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public Usuario GetOne(string user, string pass)
        {
            return UsuarioData.GetOne(user,pass);
        }

        public List<Usuario> GetAll() 
        {
            return UsuarioData.GetAll();
        }
        public void Save(Usuario usuario) 
        {
            UsuarioData.Save(usuario);
        }
        public void Delete(int id) 
        {
            UsuarioData.Delete(id);
        }
    }
    public class EspecialidadLogic : BusinessLogic
    {
        public EspecialidadAdapter EspecialidadData { get; set; }

        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
        }

        public Especialidad GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }
        public void Save(Especialidad especialidad)
        {
            EspecialidadData.Save(especialidad);
        }
        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }
    }
}
