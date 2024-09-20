using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    [ServiceContract]
    public interface IServices
    {
        [OperationContract]
        IEnumerable<ClientInfo> GetClientInfos();
        [OperationContract]
        void CreateClient(ClientInfo Cobj);
        [OperationContract]
        void UpdateClient(ClientInfo Cobj);
        [OperationContract]
        void DeleteClient(ClientInfo Cobj);
        [OperationContract]
        void ImportClientInfoFile(ClientInfo Cobj);
    }

}

[DataContract]
public class ClientInfo
{
    [DataMember]
    public Guid Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Surname { get; set; }
    [DataMember]
    public string Gender { get; set; }
}
[DataContract]
public class AdditionalInfo
{
    [DataMember]
    public int Id { get; set; }
    [EmailAddress]
    [DataMember]
    public string EmailAddress { get; set; }
    [DataMember]
    public string HomeAddress { get; set; }
    [DataMember]
    public string WorkAddress { get; set; }
    [DataMember]
    public string ContactNumber { get; set; }
    [DataMember]
    public string AlternativeContactNum { get; set; }
}

