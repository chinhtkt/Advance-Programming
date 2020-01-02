using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1252000
{
    class Lecturerfunction : IPerson2//Lecturer ke thua tu Iperson
    {
        static Lecturer[] lecturers = new Lecturer[100];
        static int m = 0;//khoi tao 1 mang moi
        static int sos = -1; //vi tri mang can tim
        String idTemp = "";
        //Co the cua nhung phuong thuc bat dau tu day
        public void AddLecturer()
        {
            Lecturer lecturer = new Lecturer();
            string Lecid = "";
            do
            {
                Console.WriteLine("Enter Lecturer ID: ");
                Lecid = Console.ReadLine();
                if (Lecid.Length == 0)
                {
                    Console.WriteLine("Enter again: ");
                }

            }
            while (Lecid.Length == 0);
            lecturer.lecId = Lecid;
            Console.WriteLine("Lecturer name :");
            lecturer.lecName = Console.ReadLine();

            Console.WriteLine("Lecturer Date of birth :");
            lecturer.lecDateofBirth = Console.ReadLine();

            Console.WriteLine("Lecturer Email: ");
            lecturer.lecEmail = Console.ReadLine();

            Console.WriteLine("Lecturer Address: ");
            lecturer.lecAddress = Console.ReadLine();

            Console.WriteLine("Lecturer Department :");
            lecturer.lecDept = Console.ReadLine();
            lecturers[m++] = lecturer;
        }

        public void DeleteLecturer()
        {
            Console.WriteLine("ID or Lecturer to delete: ");
            idTemp = Console.ReadLine();
            sos = timID(idTemp);
            if (sos == -1)
            {
                Console.WriteLine("Lecturer not found");
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    lecturers[i] = lecturers[i + 1];
                }
                m--;
                Console.WriteLine("Lecturer Deleted!!");
            }
        }

        public void SearchLecturer()
        {
            Console.WriteLine("Name of Lecturer to search:");
            idTemp = Console.ReadLine();        
            {
                Console.WriteLine("*********************************************Found Lecturer*********************************************");
                Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", new Object[] { "ID", "NAME", "DOB", "EMAIL", "ADDRESS", "DEPT" });
                for (int i = 0; i < m; i++)
                {
                    if (lecturers[i].lecName.Equals(idTemp))
                    {
                        Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", lecturers[i].lecId, lecturers[i].lecName, lecturers[i].lecDateofBirth, lecturers[i].lecEmail, lecturers[i].lecAddress, lecturers[i].lecDept);
                    }
                }
            }
           
        }

        public void UpdateLecturer()
        {
            Console.WriteLine("Id of Lecturer to update: ");
            idTemp = Console.ReadLine();
            sos = timID(idTemp);
            if (sos == -1)
            {
                Console.WriteLine("Lecturer not found");
            }
            else
            {
                Console.WriteLine("Lecturer New Name: ");
                lecturers[sos].lecName = Console.ReadLine();
                Console.WriteLine("Lecturer New Date of birth: ");
                lecturers[sos].lecDateofBirth = Console.ReadLine();
                Console.WriteLine("Lecturer New Email: ");
                lecturers[sos].lecEmail = Console.ReadLine();
                Console.WriteLine("Lecturer New Address: ");
                lecturers[sos].lecAddress = Console.ReadLine();
                Console.WriteLine("Lecturer New Class: ");
                lecturers[sos].lecDept = Console.ReadLine();
            }
        }

        public void ViewallLecturer()
        {
            Console.WriteLine("*********************************************LIST LECTURERS*********************************************");
            Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", new Object[] { "ID", "NAME", "DOB", "EMAIL", "ADDRESS", "DEPT" });
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("{0,-15}|{1,-15}|{2,-15}|{3,-22}|{4,-15}|{5,-15}", lecturers[i].lecId, lecturers[i].lecName, lecturers[i].lecDateofBirth, lecturers[i].lecEmail, lecturers[i].lecAddress, lecturers[i].lecDept);
            }
        }
        static Boolean biTrung(String id)
        {
            for (int i = 0; i < m; i++)
            {
                return true;
            }
            return false;
        }
        static int timID(String id)
        {
            for (int i = 0; i < m; i++)
            {
                if (lecturers[i].lecId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
