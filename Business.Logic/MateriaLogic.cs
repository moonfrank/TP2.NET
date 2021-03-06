﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MateriaLogic:IBusinessLogic<Materia>
    {
        public MateriaAdapter MateriaData { get; set; }

        public MateriaLogic()
        {
            this.MateriaData = new MateriaAdapter();
        }

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }
        public void Save(Materia materia)
        {
            MateriaData.Save(materia);
        }
        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}
