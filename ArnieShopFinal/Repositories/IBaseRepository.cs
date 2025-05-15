using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnieShopFinal.Repositories
{
    public interface IBaseRepository<T>
    {
        public IEnumerable<T> getAll();
        public T get(int id);
        public void update(T entity);
        public void delete(int id);
        public void insert(T entity);
    }
}
