using System;

namespace GM.Model
{
    public class TokenAuthentication
    {
        public String Audience { get; set; }
        public String SecretKey { get; set; }
        public String Path { get; set; }
    }
}
