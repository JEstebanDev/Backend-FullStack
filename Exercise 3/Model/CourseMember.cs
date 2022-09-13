

namespace ClassManager.Model
{
    public class CourseMember
    {
        public string idCourse;
        public string idMember;

        public CourseMember()
        {
        }

        public CourseMember(string idCourse, string idMember)
        {
            this.idCourse = idCourse;
            this.idMember = idMember;
        }

        public string IdCourse => idCourse;
        public string IdMember => idMember;
    }
}
