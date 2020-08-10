﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class ComisionLogic:IBusinessLogic<Comision>
    {
        public ComisionAdapter ComisionData { get; set; }

        public ComisionLogic()
        {
            this.ComisionData = new ComisionAdapter();
        }

        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }
        public void Save(Comision comision)
        {
            ComisionData.Save(comision);
        }
        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }

    }
}
