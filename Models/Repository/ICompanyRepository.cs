using System;
using System.Collections.Generic;

namespace Produt_Management.Models.Repository
{
    public interface ICompanyRepository<T>
    {
        public T Get(int id);
        public IEnumerable<T> GetAll();

        public void Add(T product);
        public T Update(T product);
        public T Delete(int id);
    }
}
