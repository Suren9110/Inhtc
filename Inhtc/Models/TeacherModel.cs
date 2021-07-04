using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhtc.Models
{
    public class TeacherModel:MemberModel
    {
        public TeacherModel(int age, string name, DateTime birthDate, Guid id):base(age,name,birthDate,id)
        {
        }
        public List <StudentModel> _students;
    }
}
