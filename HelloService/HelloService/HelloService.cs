using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string GetMessageWithoutAnyProtection()
        {
            return "Message without signed and encrytion";
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
