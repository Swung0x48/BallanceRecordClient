using System.Collections.Generic;

namespace BallanceRecordApi.Contracts.V1.Responses
{
    public class AuthSuccessResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}