using System;
using System.Collections.Generic;
using System.Text;

namespace CashVan.Common.Dto
{
    public class SendOtpDto
    {
        public string sender { get; set; }
        public string mobile { get; set; }
        public string content { get; set; }
    }
}
