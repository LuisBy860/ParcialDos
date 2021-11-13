using ParcialDos.Models;
using ParcialDos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialDos.Repository
{
    public class StudentsRepository : IStudents
    {
        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities(); //recordar hacer refrencia la base de datos siempre

        public void Save(Students c)
        {

            bd.Students.Add(c);
            bd.SaveChanges();

        }

        public List<Students> ListOfStudents()
        {

            var listadoestudiantes = bd.Students.ToList();

            return listadoestudiantes;
        }

     
         public List<Students> ListDataStudents()
        {
         
            var ListOfDataOfStudents = bd.Students.ToList();

            return ListOfDataOfStudents;
        }
    }
}