using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract(ProtectionLevel = ProtectionLevel.None)]
        string GetMessageWithoutAnyProtection();
        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        string GetSignedMessage();
        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        string GetSignedAndEncrytedMessage();
    }
}
