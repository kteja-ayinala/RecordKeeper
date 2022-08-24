using Microsoft.AspNetCore.Mvc;
using RecordKeeper.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordKeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly RecordKeeperDataContext _context;
        public TenantController(RecordKeeperDataContext context)
        {
            _context=context;
        }
        // GET: api/<TenantController>
        [HttpGet]
        public IEnumerable<Tenant> Get()
        {
            return _context.Tenants;
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        public Tenant Get(int id)
        {
            var x = _context.Tenants.Find(id);
            return x;
        }

        // POST api/<TenantController>
        [HttpPost]
        public void Post([FromBody] Tenant value)
        {
            _context.Tenants.Add(value);
            _context.SaveChanges();
        }


    }
}
