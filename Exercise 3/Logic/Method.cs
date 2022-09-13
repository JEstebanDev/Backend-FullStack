using ClassManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassManager.Logic
{
    public class Method
    {
        public Member AddUser()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastname = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.Write("Roles (1=Manager, 2=Trainer, 3=Student): ");
            short role = Convert.ToInt16(Console.ReadLine());

            Role roleType = CheckRole(role);

            string ID = "JALAU" + Guid.NewGuid().ToString().Substring(0, 5);

            return new Member(ID, name, lastname, email, _role: roleType);
        }
        public Course AddCourse(List<Member> listMembers)
        {
            Console.Write("Name Course: ");
            string nameCourse = Console.ReadLine();

            ListUser(Role.Manager, listMembers);

            Console.Write("Type ID_Manager:");
            string idManager = Console.ReadLine();

            Member manager = CheckUser(listMembers, idManager);


            ListUser(Role.Trainer, listMembers);

            Console.Write("Type ID_Trainer:");
            string idTrainer = Console.ReadLine();

            Member trainer = CheckUser(listMembers, idTrainer);

            string ID = "JALAC" + Guid.NewGuid().ToString().Substring(0, 5);

            return new Course(ID, nameCourse, manager, trainer);
        }
        private static Member CheckUser(List<Member> listMembers, string idUser)
        {
            bool value = true;
            while (value)
            {
                foreach (var member in listMembers)
                {
                    if (member.Id.Equals(idUser))
                    {
                        value = false;
                        return new Member(member.Id, member.Name, member.LastName, member.Email, member.Role);
                    }
                }
                if (value)
                {
                    Console.Write("Error Type the ID again:");
                    string idTrainer = Console.ReadLine();
                    idUser = idTrainer;
                }
            }
            return new Member();
        }

        public List<CourseMember> AddStudentToCourse(List<Member> listMembers, List<Course> listCourses)
        {
            //no puede ser creado de aqui porque pueden ya existir estudiantes entonces escribe mas

            List<CourseMember> listCourseMember = new List<CourseMember>();

            ListCoursesInfo(listCourses);
            Console.Write("\nType the course ID:");
            string idCourse = Console.ReadLine();

            CheckCourse(listCourses, idCourse);

            ListUser(Role.Student, listMembers);

            Console.Write("How many students will you add?");
            short nStudents = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < nStudents; i++)
            {
                Console.Write("Type the students's ID:");
                string idStudent = Console.ReadLine();
                Member member = CheckUser(listMembers, idStudent);
                listCourseMember.Add(new CourseMember(idCourse, member.Id));
            }
            return listCourseMember;
        }
        public Course CheckCourse(List<Course> listCourses, string idCourse)
        {
            bool value = true;
            while (value)
            {
                foreach (var course in listCourses)
                {
                    if (course.Id.Equals(idCourse))
                    {
                        value = false;
                        return new Course(course.Id, course.Name, course.Manager, course.Trainer);
                    }
                }
                if (value)
                {
                    Console.Write("Error Type the ID again:");
                    string idCourseAgain = Console.ReadLine();
                    idCourse = idCourseAgain;
                }
            }
            return new Course();
        }


        
        public void ListUser(Role role, List<Member> listMembers)
        {
            Console.WriteLine("| {0, -10} | {1, -20} | {2, -21} | {3, -9} |", "ID", "NAME", "EMAIL", "ROL");
            Console.WriteLine("|------------|----------------------|-----------------------|-----------|");
            foreach (var member in listMembers)
            {
                if (member.Role.Equals(role))
                {
                    dataMemberPrint(member);
                }
                if (role == 0)
                {
                   dataMemberPrint(member);
                }
            }
        }

        public void ListCoursesFull(List<Course> listCourses, List<Member> listMembers, List<CourseMember> listCourseMember)
        {
            foreach (var course in listCourses)
            {
                List<String> listIdMember = new List<String>();
                dataCoursePrint(course); 
                listCourseMember.ForEach(courserMember =>
                {
                    if (course.Id.Equals(courserMember.idCourse))
                        listIdMember.Add(courserMember.IdMember);
                });
                Console.WriteLine("| {0, -10} | {1, -20} | {2, -21} | {3, -9} |", "ID", "NAME", "EMAIL", "ROL");
                Console.WriteLine("|------------|----------------------|-----------------------|-----------|");

                foreach (var item in listIdMember)
                {
                    foreach (var member in listMembers)
                        if (item.Equals(member.Id))
                            dataMemberPrint(member);
                }
                listIdMember = new List<string>();
            }

        }

        internal void EditUser(List<Member> listMembers, List<Course> listCourses)
        {
            Console.Write("Type the user's id: ");
            string idUser = Console.ReadLine();
            Member member = CheckUser(listMembers, idUser);
            Course course = listCourses.Find(e => e.Manager.Id.Equals(idUser));

            if (course.Manager != null)
            {
                Console.WriteLine("The user cannot be modifier, because he has assigned courses");
            }
            else
            {
                foreach (var member1 in listMembers)
                {
                    if (member1.Id.Equals(idUser))
                    {
                        Console.Write("Name: ");
                        member1.Name = Console.ReadLine();
                        Console.Write("Last Name: ");
                        member1.LastName = Console.ReadLine();
                        Console.Write("email: ");
                        member1.Email = Console.ReadLine();
                        Console.Write("Roles (1=Manager, 2=Trainer, 3=Student): ");
                        short role = Convert.ToInt16(Console.ReadLine());
                        member1.Role = CheckRole(role);
                    }
                }
            }
        }

        public void ListCoursesInfo(List<Course> listCourses)
        {
            foreach (var course in listCourses)
            {
                dataCoursePrint(course);
            }
        }

        private void dataCoursePrint(Course course)
        {
            Console.WriteLine(course.ToString());
            Console.WriteLine("| {0, -10} | {1, -20} | {2, -20} | {3, -9} |", "ID", "NAME", "EMAIL", "ROL");
            Console.WriteLine("|------------|----------------------|----------------------|-----------|");
            Console.WriteLine("| {0, -10} | {1, -20} | {2, -20} | {3, -9} |",
                      course.Manager.Id, course.Manager.Name + " " + course.Manager.LastName, course.Manager.Email, course.Manager.Role);
            Console.WriteLine("| {0, -10} | {1, -20} | {2, -20} | {3, -9} |",
                      course.Trainer.Id, course.Trainer.Name + " " + course.Trainer.LastName, course.Trainer.Email, course.Trainer.Role);
        }

        private void dataMemberPrint(Member member)
        {
            Console.WriteLine(
                     "| {0, -10} | {1, -20} | {2, -21} | {3, -9} |",
                     member.Id, member.Name + " " + member.LastName, member.Email, member.Role);
        }

        public Role CheckRole(short role)
        {
            Role roleType = 0;
            if (role == 1) roleType = Role.Manager;
            if (role == 2) roleType = Role.Trainer;
            if (role == 3) roleType = Role.Student;
            return roleType;
        }
    }

}
