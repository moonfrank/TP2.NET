﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class PlanLogic : IBusinessLogic<Plan>
    {
        public PlanAdapter PlanData { get; set; }

        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }

        public Plan GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }
        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }
        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
