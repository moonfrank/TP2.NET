using System.Collections.Generic;
using Business.Entities;

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
