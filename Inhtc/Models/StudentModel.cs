using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhtc.Models
{
    public class StudentModel:MemberModel
    {

        public StudentModel(int age, string name, DateTime birthDate, Guid id):base(age,name,birthDate,id)
        {
            
        }
        public TeacherModel _teacher;
    }
}
