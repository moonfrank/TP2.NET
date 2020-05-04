using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        public int IDPlan { get; set; }
        public int HsSemanales { get; set; }
        public int HsTotales { get; set; }
        public string Descripcion { get; set; }
    }


}
