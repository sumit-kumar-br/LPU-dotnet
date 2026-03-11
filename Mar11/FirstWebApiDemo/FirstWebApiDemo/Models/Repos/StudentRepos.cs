using System.Linq;

namespace FirstWebApiDemo.Models.Repos
{
    public class StudentRepos : IRepos<Student>
    {
        public static List<Student> studList = null;
        public StudentRepos()
        {
            if(studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=101,Name="Sumit",City="Jalandhar",PhoneNumber="9876543210"},
                    new Student(){RollNo=101,Name="Virat",City="Ludhiana",PhoneNumber="9876543210"},
                    new Student(){RollNo=101,Name="Rohit",City="Phagwara",PhoneNumber="9876543210"},
                };
            }
        }
        public bool Add(Student item)
        {
            bool flag = false;
            if(item != null)
            {
                studList.Add(item);
                flag = true;
            }
            return flag;
        }

        public bool Delete(int id)
        {
            bool flag = false;
            Student existStudent = studList.Find(s => s.RollNo == id);
            if(existStudent != null)
            {
                studList.Remove(existStudent);
                flag = true;
            }
            return flag;
        }

        public Student Get(int id)
        {
            Student stud = studList.Find(s=>s.RollNo == id);
            if(stud != null)
            {
                return stud;
            }
            else
            {
                throw new Exception("Student Record Not Available.");
            }
        }

        public ICollection<Student> GetAll()
        {
            return studList;
        }

        public bool Update(int id, Student currStudent)
        {
            bool flag = false;
            Student existStudent = studList.Find(s => s.RollNo == id);
            if(existStudent != null && currStudent != null)
            {
                existStudent.Name = currStudent.Name;
                existStudent.City = currStudent.City;
                existStudent.PhoneNumber = currStudent.PhoneNumber;
                flag = true;
            }
            return flag;
        }
    }
}
