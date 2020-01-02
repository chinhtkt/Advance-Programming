using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1252000
{
    class Program
    {
        //phuong thuc chinh
        static void Main(string[] args)
        {
            Studentfunction t = new Studentfunction(); //tao doi tuong moi
            Lecturerfunction l = new Lecturerfunction(); //tao doi tuong moi

            while(true)
            {
                //cau truc re nhanh
                Console.Clear();
                Console.WriteLine("\nMain Menu\n");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Students Manage\n");
                Console.WriteLine("2. Lecturers Manage\n");
                Console.WriteLine("3. Exit\n");
                Console.WriteLine("-----------------------------------");
                int choice = int.Parse(Console.ReadLine());//hanh dong cua nguoi dung
                switch (choice)
                {
                    case 1:
                        do
                        {
                        

                            Console.WriteLine("\nStudent Manage\n");
                            Console.WriteLine("1. Add\n");
                            Console.WriteLine("2. View all\n");
                            Console.WriteLine("3. Search\n");
                            Console.WriteLine("4. Delete\n");
                            Console.WriteLine("5. Update\n");
                            Console.WriteLine("6. Return to Main Menu\n");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    t.AddStudent();//goi phuong thuc o day
                                    break;
                                case 2:
                                    t.ViewallStudent();
                                    break;
                                case 3:
                                    t.Searchstudent();
                                    break;
                                case 4:
                                    t.Deletestudent();
                                    break;
                                case 5:
                                    t.Updatestudent();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("You must choose function from 1 to 6");
                                    break;
                            }
                        }
                        while (choice != 6);
                        break;

                    case 2:
                        do
                        {

                            Console.WriteLine("\n Lecturer Manage \n");
                            Console.WriteLine("1. Add\n");
                            Console.WriteLine("2. View all\n");
                            Console.WriteLine("3. Search\n");
                            Console.WriteLine("4. Delete\n");
                            Console.WriteLine("5. Update\n");
                            Console.WriteLine("6. Return to Main Menu\n");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    l.AddLecturer();
                                    break;
                                case 2:
                                    l.ViewallLecturer();
                                    break;
                                case 3:
                                    l.SearchLecturer();
                                    break;
                                case 4:
                                    l.DeleteLecturer();
                                    break;
                                case 5:
                                    l.UpdateLecturer();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("You must choose function from 1 to 6");
                                    break;
                            }
                        }
                        while (choice != 6);
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
