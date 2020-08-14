using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class DocenteCursoLogic
    {
        public DocenteCursoAdapter CursoData { get; set; }

        public DocenteCursoLogic()
        {
            this.CursoData = new DocenteCursoAdapter();
        }

        public DocenteCurso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public List<DocenteCurso> GetAll()
        {
            return CursoData.GetAll();
        }
        public void Save(DocenteCurso DocenteCurso)
        {
            CursoData.Save(DocenteCurso);
        }
        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
