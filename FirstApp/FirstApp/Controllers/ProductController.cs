using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace FirstApp.Controllers
{
    public class ProductController:Controller
    {
        //public ContentResult Detail()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Product detail sehifesi";

        //    return result;
        //}


        //public JsonResult Detail()
        //{
        //    //JsonResult result = new JsonResult(new { Name = "Iphone 12", Price = 2300 });
        //    //return result;

        //    return Json(new { Name = "Iphone 12", Price = 2300 });
        //}

        public ViewResult Detail(int id)
        {
            ViewResult result = new ViewResult();
            result.ViewName = "Detail";

            return result;

            
        }

        //public ContentResult Index(string name,string surname, int age)
        //{
        //    //ViewResult result = new ViewResult();
        //    //result.ViewName = "Index";


        //    return Content(name+" "+surname+" "+age);
        //}

        public ContentResult Index(int id)
        {
            return Content(id.ToString());
        }

    }
}
