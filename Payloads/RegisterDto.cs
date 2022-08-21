using System;

namespace ReadCat.Payloads
{
    public class RegisterDto
    {
        public String nickname { get; set; }
        public String email { get; set; }
        public String username { get; set; }
        public String password { get; set; }
    }
}
