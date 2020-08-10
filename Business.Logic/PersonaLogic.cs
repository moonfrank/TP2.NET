using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class PersonaLogic : IBusinessLogic<Persona>
    {
        public PersonaAdapter PersonaData { get; set; }
        public PersonaLogic()
        {
            this.PersonaData = new PersonaAdapter();
        }
        public Persona GetOne(int ID)
        {
            return PersonaData.GetOne(ID);
        }
        public List<Persona> GetAll()
        {
            return PersonaData.GetAll(); 
        }
        public void Save(Persona persona)
        {
            PersonaData.Save(persona);
        }
        public void Delete(int ID)
        {
            PersonaData.Delete(ID);
        }
    }
}
