using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace DAL
{
    public interface IRepository<T> where T : IIdentifiable
    {
        string connexionString = ConfigurationManager.ConnectionStrings["connexionString"].ConnectionString;
        var connection = new SqlConnection(connexionString);
        connection.Open();

        
        
        List<T> GetAll();
        void Insert(T element);
        T GetById(int id);
        void Update(T competitor);
        void Delete(int id);
    }
}
