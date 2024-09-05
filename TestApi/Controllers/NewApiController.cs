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
        string date = DateTime.Now.ToString("F");
        List<ApiRecord> TestRecord = new();
        [HttpGet(Name = "NewApi")]
        public Array NewApiMethod()
        {
            ApiRecord hyt = new(1, "Amaechi", date);
            ApiRecord hyt2 = new(2, "Jude", date);
            ApiRecord hyt3 = new(3, "WellaHealth", date);

            TestRecord.Add(hyt);
            TestRecord.Add(hyt2);
            TestRecord.Add(hyt3);

            return TestRecord.ToArray();
        }

        [HttpPost(Name = "NewApiPost")]
        public IActionResult NewApiPost([FromBody] ApiRecord wellaRecord)
        {
            if (wellaRecord == null)
            {
                return BadRequest("Empty Record");
            }
            else
            {
                string date = DateTime.Now.ToString("F");
                ApiRecord Haha = new(wellaRecord.Id, $"{wellaRecord.Name}", date);

                TestRecord.Add(Haha);

                return Ok(TestRecord.ToArray());
            }

        }
    }
}
