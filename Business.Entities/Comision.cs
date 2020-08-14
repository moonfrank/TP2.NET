using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public new int ID { get; set; }
        public int IDPlan { get; set; }
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
    }
}

