using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QLVS_1911060974_Hai
{
        [DataContract]
        public class Class1
        {
            [DataMember]
            public int Masv { get; set; }
            [DataMember]
            public string Tensv { get; set; }
            [DataMember]
            public string Hocphan { get; set; }
            [DataMember]
            public int Makhoa { get; set; }
            [DataMember]
            public int Malop { get; set; }
    }
}
