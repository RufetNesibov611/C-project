using Repostories.Repostory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Repostory
{
    public class BaseRepostories<T> : IBaseRepostories<T> where T : 
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delet(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
