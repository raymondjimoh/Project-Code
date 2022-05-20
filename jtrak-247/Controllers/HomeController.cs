using jtrak_247.Repositories;
using System.Web.Mvc;

namespace jtrak_247.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEquipmentChecklist()
        {
            var equipmentList = new EquipmentRepository().GetAll();

            return Json(equipmentList, JsonRequestBehavior.AllowGet);
        }
    }
}