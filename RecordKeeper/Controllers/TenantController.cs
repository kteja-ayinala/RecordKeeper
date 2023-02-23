using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Get()
        {
             var tenants = await _context.Tenants.ToListAsync();
             return Ok(tenants);
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public  IActionResult Get(int id)
        {
            var tenant = _context.Tenants.Find(id);
            return Ok(tenant);
        }

        // POST api/<TenantController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Post([FromBody] Tenant value)
        {
            value.StartDate = DateTime.Parse(value.StartDate.ToString());
            value.EndDate = DateTime.Parse(value.EndDate.ToString());
            await _context.Tenants.AddAsync(value);
            _context.SaveChanges();

            return Ok(value);
        }


    }
}
