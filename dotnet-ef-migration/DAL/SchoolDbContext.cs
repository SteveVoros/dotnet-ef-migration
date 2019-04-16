using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolDbContext : SchoolContext
    {

        public SchoolDbContext() : base("sqlconnectionstring")
        {
        }
    }
}