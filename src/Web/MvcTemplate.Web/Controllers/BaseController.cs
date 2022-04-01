namespace NurseCallMvc.Web.Controllers
{
    using System.Web.Mvc;

    using NurseCallMvc.Services.Web;

    public abstract class BaseController : Controller
    {
        public ICacheService Cache { get; set; }
    }
}