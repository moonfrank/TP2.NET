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
        public Data.Database.UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public Business.Entities.Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll() 
        {
            return UsuarioData.GetAll();
        }
        public void Save(Business.Entities.Usuario usuario) 
        {
            UsuarioData.Save(usuario);
        }
        public void Delete(int id) 
        {
            UsuarioData.Delete(id);
        }
    }
}
