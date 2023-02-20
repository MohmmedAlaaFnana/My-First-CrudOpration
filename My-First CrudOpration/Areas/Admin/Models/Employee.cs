using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_CrudOpration.Areas.Admin.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string NameTask { get; set; }

        public string UserName { get; set; }

        public DateTime DOB { get; set; }

        public int UserId { get; set; }
    }
}

