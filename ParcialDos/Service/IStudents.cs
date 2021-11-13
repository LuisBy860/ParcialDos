using ParcialDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDos.Service
{
    interface IStudents
    {

        void Save(Students c);


        List<Students> ListDataStudents();


        List<Students> ListOfStudents();

       


    }
    
}

