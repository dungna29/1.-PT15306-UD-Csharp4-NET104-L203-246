using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAI_1_0_TaoDuAnMVC.Models
{
    public class ServiceStudent
    {
        private List<Student> _lstStudent = new List<Student>();
        public ServiceStudent()
        {
            var st1 = new Student("Dungna", "Học C#4 ở POLY");
            var st2 = new Student("Dungna", "Học C#4 ở POLY");
            _lstStudent.Add(st1);
            _lstStudent.Add(st2);
        }

        public List<Student> getLstStudent()
        {
            return _lstStudent;
        }
    }
}
