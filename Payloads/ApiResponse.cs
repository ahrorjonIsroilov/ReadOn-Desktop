using System;

namespace ReadCat.Payloads
{
    public class ApiResponse
    {
        public Object data { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
    }
}
