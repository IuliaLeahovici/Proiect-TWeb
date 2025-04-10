using eUseControl.BussinesLogic.Interfaces;
using eUseControl.BussinesLogic;
using eUseControl.Data.Enums;
using eUseControl.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.Web.Attributes
{
    public class AdminModeAttribute : ActionFilterAttribute
    {
        private readonly ISession _sessionBusinessLogic;
        public AdminModeAttribute()
        {
            var businessLogic = new BussinessLogic();
            _sessionBusinessLogic = businessLogic.GetSessionBL();
        }

    }

}