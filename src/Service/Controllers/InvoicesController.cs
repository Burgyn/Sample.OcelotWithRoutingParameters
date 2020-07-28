using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("{companyId}/api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int companyId)
            => Ok(Enumerable.Range(0, 10).Select(i => $"Invoice {i} for company {companyId}"));

        [HttpGet("{invoiceId}")]
        public ActionResult<string> Get(int companyId, int invoiceId)
            => $"Invoice {invoiceId} for company {companyId}";
    }
}
