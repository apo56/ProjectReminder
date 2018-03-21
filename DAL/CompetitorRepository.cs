using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAL
{
    public class CompetitorRepository : IRepository<Competitor>
    {
        private SqlConnection DBConnexion ;

        public CompetitorRepository()
        {
            DBConnexion = new DBConnexion().OpenConnexion();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Competitor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Competitor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Competitor element)
        {
            throw new NotImplementedException();
        }

        public void Update(Competitor competitor)
        {
            throw new NotImplementedException();
        }
    }
}
