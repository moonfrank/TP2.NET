﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public new int ID { get; set; }
        public int IDEspecialidad { get; set; }
        public string Descripcion { get; set; }
    }

}
