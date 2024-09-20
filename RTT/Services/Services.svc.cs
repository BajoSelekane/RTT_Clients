using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    public class Services : IServices
    {
        public void CreateClient(ClientInfo Cobj)
        {
            DataContext context = new DataContext();
            context.ClientInfos.Add(Cobj);
            context.SaveChanges();
        }

        public void DeleteClient(ClientInfo Cobj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientInfo> GetClientInfos()
        {
            throw new NotImplementedException();
        }

        public void ImportClientInfoFile(ClientInfo Cobj)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(ClientInfo Cobj)
        {
            throw new NotImplementedException();
        }
    }


}
