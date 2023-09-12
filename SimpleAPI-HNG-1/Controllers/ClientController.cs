using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI_HNG_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get(string slack_name, string track)
        {
            
        }

        public class UserModel 
        {
            public string slack_name { get; set; }
            public string current_day { get; set; } = DateTime.Now.Day.ToString();
            public string utc_time { get; set; } = DateTime.UtcNow.ToString();
            public string track { get; set; } = "";
            public string github_file_url { get; set; } = "";
            public string github_repo_url { get; set; } = "";
        }
    }
}