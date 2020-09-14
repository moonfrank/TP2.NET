using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : IBusinessLogic<Usuario>
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
            return UsuarioData.GetOne(user, pass);
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
        public void DeleteIDPersona(int id)
        {
            UsuarioData.DeleteIDPersona(id);
        }
    }
}