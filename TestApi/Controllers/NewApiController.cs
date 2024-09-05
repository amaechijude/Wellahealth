using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
        List<NewApiClass> TestRecord = new();
        
        [HttpGet(Name = "NewApi")]
        public List<NewApiClass> NewApiMethod()
        {
            return TestRecord;
        }

        [HttpPost(Name = "NewApiPost")]
        public IActionResult NewApiPost([FromBody] NewApiClass wellaRecord)
        {
            if (wellaRecord == null)
            {
                return BadRequest("Empty Record");
            }
            else if (wellaRecord.NameN == null)
            {
                return BadRequest("Name Cannot be blank");
            }
           
            // string date = DateTime.Now.ToString("F");
            // WellaRecord NewRecord = new WellaRecord();

            TestRecord.Add(wellaRecord);
            return Ok(wellaRecord);
        }
    }
}

