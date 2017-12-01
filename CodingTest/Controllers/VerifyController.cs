using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    [Route("api/[controller]")]
    public class VerifyController : Controller
    {
        [HttpPost]
        [Route("register")]
        public IActionResult Post([FromBody]string firstName, [FromBody]string lastName, [FromBody]string dateOfBirth)
        {
            return Ok(BackgroundCheckService.RegisterApplicant(firstName, lastName, dateOfBirth));
        }

        [HttpPost]
        public IActionResult Post([FromBody]string ssn, [FromBody]string applicantId)
        {
            return Ok(BackgroundCheckService.VerifyApplication(ssn, applicantId));
        }


    }
}
