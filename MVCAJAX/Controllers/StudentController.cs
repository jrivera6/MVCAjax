using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Service;
using MVCAJAX.Models;

namespace MVCAJAX.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();
        // GET: Student

        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Address = c.studentAddress,
                             Name = c.studentName
                         }).ToList();

            return View(model);
        }

        public ActionResult IndexTarea()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Code = c.studentCode,
                             Name = c.studentName,
                             LastName = c.studentLastName,
                             Address = c.studentAddress,
                         }).ToList();

            return View(model);
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult studentDetail(int id)
        {
            return Json(service.GetById(id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult createStudent(Student student)
        {
            student.createdAt = DateTime.Now;
            student.active = true;
            service.Insert(student);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        [HttpPost]
        public ActionResult updateStudent(Student student,int id)
        {
            student.updateAt = DateTime.Now;
            service.Update(student,id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        [HttpPost]
        public ActionResult deleteStudent(int id)
        {
            service.Delete(id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult searchStudents(string query)
        {

            return Json(service.SearchStudents(query), JsonRequestBehavior.AllowGet);

        }
    }
}