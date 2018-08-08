using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// https://blogs.msdn.microsoft.com/odatateam/2018/07/03/asp-net-core-odata-now-available/

namespace ODataCore.Controllers
{
    public class BooksController : ODataController
    {
        [EnableQuery(PageSize = 10)]
        public IActionResult Get()
        {
            return Ok(DataSource.GetBooks().AsQueryable());
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(DataSource.GetBooks().FirstOrDefault(c => c.Id == key));
        }
    }
}