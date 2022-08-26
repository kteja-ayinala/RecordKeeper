using Microsoft.AspNetCore.Mvc;
using RecordKeeper.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordKeeper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantStayInfoController : ControllerBase
    {
        private readonly RecordKeeperDataContext _context;
        public TenantStayInfoController(RecordKeeperDataContext context)
        {
            _context = context;
        }


        // GET: api/<TenantStayInfoController>
        [HttpGet]
        public IEnumerable<TenantStayInfo> Get()
        {
            return _context.TenantStayInfos;
        }

        // GET api/<TenantStayInfoController>/5
        [HttpGet("{id}")]
        public TenantStayInfo Get(int id)
        {
            return _context.TenantStayInfos.Find(id);
        }

        // POST api/<TenantStayInfoController>
        [HttpPost]
        public void Post([FromBody] TenantStayInfo value)
        {
            _context.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<TenantStayInfoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TenantStayInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
