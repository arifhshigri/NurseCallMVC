namespace NurseCallMvc.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }
        public ActionResult Chat()
        {
            return View();
        }
    }
}