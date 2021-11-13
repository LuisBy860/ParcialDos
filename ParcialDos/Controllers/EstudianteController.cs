using ParcialDos.Models;
using ParcialDos.Models.ViewModels;
using ParcialDos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcialDos.Controllers
{
    public class EstudianteController : Controller
    {

        CoursesRepository coursesRepository = new CoursesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();
        Students students = new Students();
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Combobox()
        {
            var informationofStudents = studentsRepository.ListOfStudents();
            var informationofCourse = coursesRepository.ListDataCourses();


            List<SelectListItem> ComboboxOfStudents = new List<SelectListItem>();
            List<SelectListItem> ComboboxOfCourses = new List<SelectListItem>();




            foreach (var iteracion in informationofStudents)
            {


                ComboboxOfStudents.Add(new SelectListItem


                {
                    Text = iteracion.FirstMidName,
                    Value = Convert.ToString(iteracion.StudentId)


                }




                    );


                ViewBag.listofstudentcombobox = ComboboxOfStudents;


            }




            foreach (var iteracion in informationofCourse)
            {


                ComboboxOfCourses.Add(new SelectListItem


                {
                    Text = iteracion.Title,
                    Value = Convert.ToString(iteracion.CouserId)


                }




                    );


                ViewBag.listofcoursescombobox = ComboboxOfCourses;


            }


            return View();


        }

        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult getcombo(Erollements e)
        {


           

            return View("Combobox");


        }
      
        public ActionResult Registrador()
        {


            return View(); 


        }
        [HttpGet]
        public ActionResult Registrardors(EstudianteViewModel studentss)
        {

            if (ModelState.IsValid)
            {
                return View("Registrador", studentss);
            }
            else
                return Redirect("Registrore");


        }
        
        public ActionResult Registrore()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrores(Students studentss)
        {

            StudentsRepository studentsRepository = new StudentsRepository();

            studentsRepository.Save(studentss);

            var ListOfData = studentsRepository.ListDataStudents();

            return View(ListOfData); //razor page nos adactara
        }
    }
}