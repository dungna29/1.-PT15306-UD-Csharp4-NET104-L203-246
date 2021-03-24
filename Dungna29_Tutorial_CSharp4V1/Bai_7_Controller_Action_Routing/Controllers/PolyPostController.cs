using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_7_Controller_Action_Routing.Controllers
{
    public class PolyPostController : Controller
    {
        public string PostById(int id)
        {
            return "Action PostById int id = " + id;
        }
        public string PostByName(string id)
        {
            return "Action PostByName string id = " + id;
        }

        public string RegexPoly(int year)
        {
            return "Action RegexPoly year = " + year.ToString();
        }

        public string CombingConstraints(string id)
        {
            return "Action CombingConstraints id = " + id;
        }
    }
}
