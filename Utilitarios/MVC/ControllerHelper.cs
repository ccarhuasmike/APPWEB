using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Utilitarios.Quality;

namespace Utilitarios.MVC
{
    public class ControllerHelper: Controller
    {
        protected JsonResult CrObject(ValidationResponse vr)
        {
            return vr.Status == Status.Error
                ? Json(new { Result = vr.Mensaje, Status = "ERROR" }, JsonRequestBehavior.AllowGet)
                : Json(new { Result = vr.Resultado, Status = "OK" }, JsonRequestBehavior.AllowGet);
        }
    }
}
