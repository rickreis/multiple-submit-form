using System.Web;
using System.Web.Mvc;

namespace MultipleSubmitForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Index"), HttpPost, Submit("edit")]
        public ActionResult Edit(string email, string password, HttpPostedFileBase file)
        {
            ViewBag.Message = "Submit Edit";

            return View("Index");
        }

        [ActionName("Index"), HttpPost, Submit("remove")]
        public ActionResult Remove(string email, string password, HttpPostedFileBase file)
        {
            ViewBag.Message = "Submit Remove";

            return View("Index");
        }
    }
}