using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSQL.Controllers
{
    public class BlogController:Controller
    {
        public ActionResult Detail()
        {
            return View();
        }
    }
}
