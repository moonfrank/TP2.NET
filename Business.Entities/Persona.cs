﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public enum TiposPersonas
        {
            Alumno,
            Profesor
        }
        public int Legajo { get; set; }
        public int IDPlan { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TiposPersonas TipoPersona { get; set; }
    }
}
