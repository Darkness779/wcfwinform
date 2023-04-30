using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFWinform
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFServiceDemo" in both code and config file together.
    [ServiceContract]
    public interface IWCFServiceDemo
    {
        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        Boolean AddStudent(Student newStudent);

        [OperationContract]
        Boolean UpdateStudent(Student updateStudent);

        [OperationContract]
        Boolean DeleteStudent(int studentID);
    }
}
