using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calc.Views.Home;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;

namespace Calc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult GetDataForAccordion(DataSourceLoadOptions loadOptions)
        {
            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(SampleData.Companies, loadOptions)),
                "application/json");
        }
        [HttpGet]
        public ActionResult GetDataForSexSelectBox(DataSourceLoadOptions loadOptions)
        {
            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(SampleData.Sex, loadOptions)),
                "application/json");
        }

        public ActionResult Dokumentacja()
        {
            return View();
        }

        public ActionResult Autorzy()
        {
            return View();
        }
    }
}