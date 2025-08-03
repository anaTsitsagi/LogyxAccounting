using System;
using System.IO;
using System.Linq;
using System.Text;
using DevExpress.AspNetCore.Spreadsheet;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Export;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace LogyxAccounting.Controllers {

    [Route("[action]")]
    public class SpreadsheetController : Controller {

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult DxDocumentRequest()
        {
            return SpreadsheetRequestProcessor.GetResponse(HttpContext);
        }

    }
}