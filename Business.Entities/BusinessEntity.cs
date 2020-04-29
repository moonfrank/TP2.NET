using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public int ID { get; set; }
        public States State { get; set; }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        public BusinessEntity()
        {
            this.State = States.New;
        }
    }

    public class Modulo:BusinessEntity
    {
        public string Descripcion { get; set; }

    }

    public class ModuloUsuario:BusinessEntity
    {
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public bool PermiteAlta { get; set; }
        public bool PermiteBaja { get; set; }
        public bool PermiteModificacion { get; set; }
        public bool PermiteConsulta { get; set; }
    }
}
