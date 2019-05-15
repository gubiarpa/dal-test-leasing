using dal_testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dal_testing.Controllers.Common
{
    public class BaseController : Controller
    {
        public ApplicationDbContext _context;

        public BaseController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}