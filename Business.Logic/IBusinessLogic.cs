using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public interface IBusinessLogic<T> where T:BusinessEntity
    {
        T GetOne(int i);
        List<T> GetAll();
        void Save(T t);
        void Delete(int i);
    }
    
}
