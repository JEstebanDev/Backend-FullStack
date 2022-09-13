using ClassManager.Logic;
using ClassManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassManager
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Method method = new Method();

            List<Member> listMembers = new List<Member>();
            List<Course> listCourses = new List<Course>();
            List<CourseMember> listCourseMember = new List<CourseMember>();
            while (true)
            {
                string strMenu = "-----MENU-----\n\n" +
                    "0.Data to test\n" +
                    "1.Add User(Manager, Trainer, Student)\n" +
                    "2.Add Course\n" +
                    "3.Add Students to Course\n" +
                    "4.List Users\n" +
                    "5.List Courses\n" +
                    "6.Edit User";

                Console.Write($"\n{strMenu}\n\nType an option or type Ctrl + C to exit: ");
                short option = Convert.ToInt16(Console.ReadLine());

                if (option==0)
                {
                    Member member1 = new Member("JALAU9d96c", "Orlando", "Campos", "orlando@jalasoft.com", Role.Manager);
                    Member member2 = new Member("JALAU9d962", "Pepito", "Perez", "Pepito@jalasoft.com", Role.Manager);

                    Member member3 = new Member("JALAU9d122", "Gaia", "Antezana", "gaia@jalasoft.com", Role.Trainer);
                    Member member4 = new Member("JALAU9d123", "Juan Pablo", "Montano", "montano@jalasoft.com", Role.Trainer);
                    Member member5 = new Member("JALAU9d124", "Rocio", "Vargas", "rocio@jalasoft.com", Role.Trainer);

                    Member member6 = new Member("JALAU5d120", "Esteban", "Castano", "esteban@jalasoft.com", Role.Student);
                    Member member7 = new Member("JALAU5d121", "Edgar", "Roman", "edgar@jalasoft.com", Role.Student);
                    Member member8 = new Member("JALAU5d122", "Jose", "Martinez", "jose@jalasoft.com", Role.Student);
                    Member member9 = new Member("JALAU5d123", "Diego", "Morales", "diego@jalasoft.com", Role.Student);
                    Member member10 = new Member("JALAU5d124", "Joaquin", "Aman", "joaquin@jalasoft.com", Role.Student);
                    Member member11= new Member("JALAU5d125", "Xochihua", "Sotarriba", "xochihua@jalasoft.com", Role.Student);
                    listMembers.Add(member1);
                    listMembers.Add(member2);
                    listMembers.Add(member3);
                    listMembers.Add(member4);
                    listMembers.Add(member5);
                    listMembers.Add(member6);
                    listMembers.Add(member7);
                    listMembers.Add(member8);
                    listMembers.Add(member9);
                    listMembers.Add(member10);
                    listMembers.Add(member11);
                    listCourses.Add(new Course("JALACe4420", "Backend", member1, member3));
                    listCourses.Add(new Course("JALACe4421", "DevOps", member1, member4));
                    listCourses.Add(new Course("JALACe4422", "UI/UX", member1, member5));
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            listCourseMember.Add(new CourseMember("JALACe442"+i, "JALAU5d12" + j));
                        }
                    }
                    
                }
                if (option == 1)
                { 
                    listMembers.Add(method.AddUser());
                }
                if (option == 2)
                {
                    listCourses.Add(method.AddCourse(listMembers));
                }
                if (option == 3)
                {
                    if (listCourses.Count()<=0)
                    {
                        Console.WriteLine("\nCreate a course first please");
                    }
                    else
                    {
                        List<CourseMember> listCourseMemberCache = method.AddStudentToCourse(listMembers, listCourses);
                        foreach (var item in listCourseMemberCache)
                        {
                            listCourseMember.Add(item);
                        }
                    }
                   
                }
                if (option == 4)
                {
                    Console.Write("Type (0=All, 1=Manager, 2=Trainer, 3=Student): ");
                    short role = Convert.ToInt16(Console.ReadLine());
                    Role roleType = method.CheckRole(role);
                    method.ListUser(roleType, listMembers);
                }
                if (option == 5)
                {
                    method.ListCoursesFull(listCourses, listMembers, listCourseMember);
                }
                if (option == 6)
                {
                    method.ListUser(0, listMembers);
                    method.EditUser(listMembers, listCourses);
                }
            }
        }
    }
}
