using Microsoft.EntityFrameworkCore;

namespace GTR_WebApiTask.DB
{
    public class taskContext: DbContext 
    {
        public taskContext(DbContextOptions options) : base(options)
        {

        }



    }
}
