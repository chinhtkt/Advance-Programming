using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1252000
{
    class Studentfunction : IPerson //Student ke thua tu Iperson
    {
        static Student[] students = new Student[100];
        static int n = 0;//khoi tao 1 mang moi
        static int haha = -1;// day se la vi tri mang can tim
        String idTemp = ""; //day la id can tim
        //Co the cua nhung phuong thuc bat dau tu day
        public void AddStudent()
        {
            
            Student student = new Student();
            string stdid = "";
            do
            {
                Console.WriteLine("Enter Student ID(Must be GTxxxxx or GCxxxxx: ");
                stdid = Console.ReadLine();
                if (stdid.Length == 0)
                {
                    Console.WriteLine("Enter again: ");
                }

            }
            while (stdid.Length == 0);
            student.stdId = stdid;
            
            Console.WriteLine("Student name:");
            student.stdName = Console.ReadLine();

            Console.WriteLine("Student Date of birth:");
            student.stdDateofbirth = Console.ReadLine();

            Console.WriteLine("Student Email: ");
            student.stdEmail = Console.ReadLine();

            Console.WriteLine("Student Address: ");
            student.stdAddress = Console.ReadLine();

            Console.WriteLine("Student Class:");
            student.stdClassbatch = Console.ReadLine();
            students[n++] = student;
        }

        public void Deletestudent()
        {
            Console.WriteLine("ID or Student to delete: ");
            idTemp = Console.ReadLine();
            haha = timbangid(idTemp);
            if(haha == -1)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                for (int i =0; i < n; i++)
                {
                    students[i] = students[i + 1];
                }
                n--;
                Console.WriteLine("Student was deleted");
            }
        }

        public void Searchstudent()
        {
            Console.WriteLine("Name of student to search:");
            idTemp = Console.ReadLine();
            Console.WriteLine("**************Found Student*************");
            Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", new Object[] { "ID", "NAME", "DOB", "EMAIL", "ADDRESS", "CLASS" });
            for (int i= 0; i < n; i++)
            {
                if(students[i].stdName.Equals(idTemp))
                {
                    Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", students[i].stdId, students[i].stdName, students[i].stdDateofbirth, students[i].stdEmail, students[i].stdAddress, students[i].stdClassbatch);
                }
            }
        }

        public void Updatestudent()
        {
            Console.WriteLine("Id of Student to update: ");
            idTemp = Console.ReadLine();
            haha = timbangid(idTemp);
            if (haha == -1)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                Console.WriteLine("Student New Name: ");
                students[haha].stdName = Console.ReadLine();
                Console.WriteLine("Student New Date of birth: ");
                students[haha].stdDateofbirth = Console.ReadLine();
                Console.WriteLine("Student New Email: ");
                students[haha].stdEmail = Console.ReadLine();
                Console.WriteLine("Student New Address: ");
                students[haha].stdAddress = Console.ReadLine();
                Console.WriteLine("Student New Class: ");
                students[haha].stdClassbatch = Console.ReadLine();
            }
        }

        public void ViewallStudent()
        {
            Console.WriteLine("*************************************************LIST STUDENT*************************************************");
            Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", new Object[] { "ID", "NAME", "DOB", "EMAIL", "ADDRESS", "CLASS" });
            for (int i =0; i < n; i++)
            {
                Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", students[i].stdId, students[i].stdName, students[i].stdDateofbirth, students[i].stdEmail, students[i].stdAddress, students[i].stdClassbatch);
            }
        }

        static Boolean bitrung(String studentid)
        {
            for (int i = 0; i < n; i++)
            {
                return true;
            }
            return false;
        }
        static int timbangid(String studentid)
        {
            for (int i =0; i < n;i++)
            {
                if (students[i].stdId.Equals(studentid))
                {
                    return i;
                }
            }
            return -1;
        }

    }
    

}
