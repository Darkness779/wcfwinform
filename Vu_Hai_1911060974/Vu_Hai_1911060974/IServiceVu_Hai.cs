using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Vu_Hai_1911060974
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IServiceVu_Hai" in both code and config file together.
    public class IServiceVu_Hai : IIServiceVu_Hai
    {
        public string GetMessageWithoutAnyProtection(string messenger)
        {
            return $"{messenger}";
        }
        public string GetSignedMessage()
        {
            return "Message with signed but without encrytion";
        }
        public string GetSignedAndEncrytedMessage()
        {
            return "Message signed and encrytion";
        }
    }
}
