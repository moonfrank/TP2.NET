using System;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public enum TiposPersonas
        {
            Alumno,
            Profesor,
            Admin
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
