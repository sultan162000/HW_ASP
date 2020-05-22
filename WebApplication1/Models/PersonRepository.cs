using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace WebApplication1.Models
{
    public class PersonRepository
    {
        const string conStr = "Data Source=localhost; Initial Catalog=alif;Integrated Security=True";

        public List<Person> GetUsers()
        {
            List<Person> persons = new List<Person>();
            using (IDbConnection db = new SqlConnection(conStr))
            {
                persons = db.Query<Person>("SELECT * FROM Person").ToList();
            }
            return persons;
        }
    }
}
