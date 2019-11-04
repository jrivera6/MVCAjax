using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infaestructure;

namespace Service
{
    public class StudentService
    {
        public List<Student> Get()
        {
            List<Student> students = null;
            using (var context = new SchoolContext())
            {
                students = context.Students.Where(x => x.active == true).ToList();
            }

            return students;
        }


        public List<Student> SearchStudents(string query)
        {
            List<Student> students = null;

            using (var context = new SchoolContext())
            {
                students = context.Students.Where(x => x.active == true && (x.studentName.Contains(query) || x.studentLastName.Contains(query))).ToList();
            }
            return students;
        }
        public Student GetById(int ID)
        {
            Student student = null;
            using (var context = new SchoolContext())
            {
                student = context.Students.Find(ID);
            }

            return student;
        }

        public void Insert(Student student)
        {
            using (var context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void Update(Student student, int ID)
        {
            using (var context = new SchoolContext())
            {
                var studentNew = context.Students.Find(ID);
                studentNew.studentCode = student.studentCode;
                studentNew.studentName = student.studentName;
                studentNew.studentLastName = student.studentLastName;
                studentNew.studentAddress = student.studentAddress;
                studentNew.updateAt = student.updateAt;
                context.SaveChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var context = new SchoolContext())
            {
                var student = context.Students.Find(ID);
                student.active = false;
                //context.Students.Remove(student);

                context.SaveChanges();
            }
        }
    }
}
