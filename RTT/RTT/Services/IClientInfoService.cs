using RTT.Entities;

namespace RTT.Services
{
    public interface IClientInfoService
    {
        Task<List<ClientInfo>> GetAllClientInfo();
    }
}
