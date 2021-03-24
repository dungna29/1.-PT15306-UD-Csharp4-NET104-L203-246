using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAI_1_0_TaoDuAnMVC.Models
{
    public class Student
    {
        private string name;
        private string des;

        public Student()
        {
            
        }

        public Student(string name, string des)
        {
            this.name = name;
            this.des = des;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Des
        {
            get => des;
            set => des = value;
        }
    }
}
