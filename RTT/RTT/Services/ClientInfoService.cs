using RTT.Data;
using RTT.Entities;
using System.Data.Entity;

namespace RTT.Services
{
    public class ClientInfoService : IClientInfoService
    {
        private readonly DataContext _Context;
        public ClientInfoService(DataContext context) 
        {
            _Context = context; 
        }
        public async Task<List<ClientInfo>> GetAllClientInfo()
        {
          var clientInfo= await  _Context.ClientInfos.ToListAsync();
            return clientInfo;
        }
    }
}
