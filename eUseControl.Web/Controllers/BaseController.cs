using eUseControl.BussinesLogic.Interfaces;
using eUseControl.BussinesLogic;
using eUseControl.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ISession _session;

        public BaseController()
        {
            var bl = new BussinessLogic();
            _session = bl.GetSessionBL();
        }

    }
}