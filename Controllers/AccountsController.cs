using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using LogyxAccounting.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using LogyxAccounting.Data;

namespace LogyxAccounting.Controllers {

    [Route("api/[controller]")]
    public class AccountsController : Controller {

        readonly AppDbContext _context;

        public AccountsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            var query = _context.Accounts;

            return DataSourceLoader.Load(query, loadOptions);
        }

    }
}