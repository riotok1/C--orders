using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Application.DB
{
    partial class Students
    {
        public string fullStudName
        {
            get
            {
                return Surname + " " + Name + " " + Patronymic;
            }
        }
    }
}
