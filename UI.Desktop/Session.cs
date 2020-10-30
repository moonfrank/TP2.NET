using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace UI.Desktop
{
    public class Session
    {
        private int _userID;
        private int _personaID;
        private Persona.TiposPersonas _tipoPersona;
        public int userID { get { return this._userID; } }
        public int personaID { get { return this._personaID; } }
        public Persona.TiposPersonas tipoPersona { get { return this._tipoPersona; } }

        public Session(int userID, int personaID, Persona.TiposPersonas tipoPersona)
        {
            this._userID = userID;
            this._personaID = personaID;
            this._tipoPersona = tipoPersona;
        }


    }
}
