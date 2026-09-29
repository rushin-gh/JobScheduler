using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Web.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        [HttpPost("create")]
        public string CreateJob(CreateJobDTO jobDTO)
        {
            var response = new Response();



            return "Job created successfully";
        }
    }
}
