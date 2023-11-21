using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repostory.Interface
{
    public interface IBaseRepostories<T>
    {
        void Create(T entity);
        void Delet(T entity);
        List<T> Edit(T entity);
        List<T> GetById(int id);
        List<T> GetAll ();



    }
}
