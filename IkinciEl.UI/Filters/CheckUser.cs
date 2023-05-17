using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IkinciEl.UI.Filters
{
    public class CheckUser : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            base.OnActionExecuting(filterContext);

            if (filterContext.ActionParameters["vm"] != null)
            {




            }
        }


    }
}