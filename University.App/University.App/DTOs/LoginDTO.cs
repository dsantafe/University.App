using Newtonsoft.Json;

namespace University.App.DTOs
{
    public class LoginReqDTO
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class LoginResDTO
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class LoginResFailDTO
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
