namespace ReadCat.Payloads
{
    public class PasswordResetDto
    {
        public string password { get; set; }
        public string prePassword { get; set; }
        public int code { get; set; }
        public string email { get; set; }
    }
}
