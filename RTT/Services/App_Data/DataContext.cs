
using System.Data.Entity;

namespace Services
{
    public class DataContext :DbContext     
    {
        public DataContext()
            :base("DefaultConnection")
        {
            
        }

        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<AdditionalInfo> AdditionalInfos { get; set; }
    }
}
