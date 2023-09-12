using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimpleAPI_HNG_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet(Name = "api")]
        public async Task<string> Get(string slack_name, string track)
        {
            var user = new UserModel
            {
                slack_name = slack_name,
                track = track
            };

            string json = JsonSerializer.Serialize(user);
            return json;
        }

        public class UserModel 
        {
            public string slack_name { get; set; }
            public string current_day { get; set; } = DateTime.Now.Day.ToString();
            public string utc_time { get; set; } = DateTime.Now.ToString();
            public string track { get; set; } = "";
            public string github_file_url { get; set; } = "";
            public string github_repo_url { get; set; } = "https://github.com/jekwupeter/SimpleAPI-HNG-1";
            public int status_code { get; set; } = ((int)HttpStatusCode.OK);
        }
    }
}