using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic
    {
        public AlumnoInscripcionAdapter inscripcionData { get; set; }

        public AlumnoInscripcionLogic()
        {
            this.inscripcionData = new AlumnoInscripcionAdapter();
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return inscripcionData.GetOne(id);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return inscripcionData.GetAll();
        }
        public void Save(AlumnoInscripcion inscripcion)
        {
            inscripcionData.Save(inscripcion);
        }
        public void Delete(int id)
        {
            inscripcionData.Delete(id);
        }
    }
}
