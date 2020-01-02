using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1252000
{
    interface IPerson //khai bao interface
    {
        //tat ca day deu la phuong thuc truu tuong
        void AddStudent();
        void ViewallStudent();
        void Searchstudent();
        void Deletestudent();
        void Updatestudent();
    }
    interface IPerson2
    {
        void AddLecturer();
        void ViewallLecturer();
        void SearchLecturer();
        void DeleteLecturer();
        void UpdateLecturer();
    }

    

}
