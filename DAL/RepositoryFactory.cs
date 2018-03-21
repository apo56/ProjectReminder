using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryFactory
    {
        

        public static IRepository<T> GetRepository<T>() where T : IIdentifiable
        {
            return new SerializerRepository<T>();
        }


    }
}
