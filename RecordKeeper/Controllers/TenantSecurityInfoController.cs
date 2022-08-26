using Microsoft.AspNetCore.Mvc;
using RecordKeeper.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordKeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantSecurityInfoController : ControllerBase
    {
        private readonly RecordKeeperDataContext _context;
        public   TenantSecurityInfoController(RecordKeeperDataContext context)
        {
            _context = context;
        }
        // GET: api/<TenantSecurityInfoController>
        [HttpGet]
        public IEnumerable<TenantSecurityInfo> Get()
        {
            return _context.TenantSecurityInfos;
        }

        // GET api/<TenantSecurityInfoController>/5
        [HttpGet("{id}")]
        public TenantSecurityInfo Get(int id)
        {
            return _context.TenantSecurityInfos.Find(id);
        }

        // POST api/<TenantSecurityInfoController>
        [HttpPost]
        public void Post([FromBody] TenantSecurityInfo value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<TenantSecurityInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TenantSecurityInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
