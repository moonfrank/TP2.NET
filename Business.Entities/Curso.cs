﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public int IDComision { get; set; }
        public int IDMateria { get; set; }
        public int Cupo { get; set; }
        public int AnioCalendario { get; set; }
    }
}
