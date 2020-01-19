using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMaaCart.AllRepository
{
   public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int model);

        void delete(int model);

        void updateModel(T Model);

        void save();

    }
}
