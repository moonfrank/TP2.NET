using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso:BusinessEntity
    {
        public enum TiposCargos
        {
           Auxiliar,
           Profesor
        }
        public int IDDocente { get; set; }
        public int IDCurso { get; set; }
        public TiposCargos Cargo { get; set; } 
    }
}
