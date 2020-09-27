using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CatalogueApi.Controllers
{
    [ApiController]
    [Route("api/currencies")]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet, Route("")]
         public ActionResult<IEnumerable<string>> Get()
         {
            return new string [] {"us","bfp","naira"};
         }
    }
}
