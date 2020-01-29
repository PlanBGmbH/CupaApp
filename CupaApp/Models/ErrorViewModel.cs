using System;

namespace CupaApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string HalloId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
