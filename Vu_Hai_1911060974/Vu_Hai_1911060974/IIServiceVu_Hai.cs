using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Vu_Hai_1911060974
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIServiceVu_Hai" in both code and config file together.
    [ServiceContract]
    public interface IIServiceVu_Hai
    {
            [OperationContract(ProtectionLevel = ProtectionLevel.None)]
            string GetMessageWithoutAnyProtection(string messenger);

            [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
            string GetSignedMessage();

            [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
            string GetSignedAndEncrytedMessage();


    }
}
