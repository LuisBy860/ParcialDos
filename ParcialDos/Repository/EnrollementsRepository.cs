using ParcialDos.Models;
using ParcialDos.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialDos.Repository
{
    public class EnrollementsRepository : IEnrollement 
    {

        EscuelaDeConexionesEntities bd = new EscuelaDeConexionesEntities();
        public List<Erollements> UnionDeTablas() //aqui podremos generar consulta  o uniones de tabla
        {
            var ConsultaJoin = bd.Erollements.Include(e => e.Students).Include(c => c.Courses).ToList();

            return ConsultaJoin;
        }
    }
}