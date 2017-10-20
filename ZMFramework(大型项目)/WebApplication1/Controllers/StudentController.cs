using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using ZM.CMS.Services;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {

        readonly IStudentServices _student;
        //构造器注入
        public StudentController(IStudentServices student)
        {
            this._student = student;
        }

        public ActionResult Index()
        {
            var data = _student.GetAll();
            return View(data);
        }

    }
}