using Microsoft.EntityFrameworkCore;
using BaseLibrary.Entities;

namespace RTT.Data
{
    public class DataContext :DbContext     
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            
        }

        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<AdditionalInfo> AdditionalInfos { get; set; }
    }
}
